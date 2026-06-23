using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    public class SubdivisionsMethods
    {
        private readonly CloudGeographyClient Client;

        internal SubdivisionsMethods(CloudGeographyClient client) => Client = client;

        public List<Subdivision> Get(string countryCode)
        {
            try
            {
                return SubdivisionsList[countryCode];
            }
            catch
            {
                return [];
            }
        }

        public List<Subdivision> Get(string countryCode, params string[] subdivisionCodes) => Get(countryCode).Where(key => subdivisionCodes.Any(s => key.CodeCheck(s))).ToList();

        public Subdivision? Get(string countryCode, string subdivisionCode) => Get(countryCode).FirstOrDefault(key => key.CodeCheck(subdivisionCode));

        public List<Subdivision>? GetChildren(string countryCode, string subdivisionCode)
        {
            Subdivision? subdivision = Get(countryCode, subdivisionCode);

            return subdivision?.Children;
        }

        public Subdivision? GetChild(string countryCode, string subdivisionCode, string childCode)
        {
            List<Subdivision>? children = GetChildren(countryCode, subdivisionCode);

            return children?.FirstOrDefault(key => key.CodeCheck(childCode));
        }

        public List<Subdivision> GetAll(string countryCode)
        {
            List<Subdivision> result = [];

            Flatten(Get(countryCode), result);

            return result;
        }

        private static void Flatten(List<Subdivision> subdivisions, List<Subdivision> result)
        {
            foreach (Subdivision subdivision in subdivisions)
            {
                result.Add(subdivision);

                if (subdivision.Children != null)
                    Flatten(subdivision.Children, result);
            }
        }

        public Subdivision? Find(string countryCode, string query) 
            => FindInList(Get(countryCode), query);

        public List<Subdivision> FindAll(string countryCode, string query)
        {
            List<Subdivision> result = [];
            FindAllInList(Get(countryCode), query, result);
            
            return result;
        }

        private static Subdivision? FindInList(List<Subdivision> subdivisions, string query)
        {
            foreach (Subdivision subdivision in subdivisions)
            {
                if (subdivision.CodeCheck(query) || subdivision.NameCheck(query))
                    return subdivision;

                if (subdivision.Children != null)
                {
                    Subdivision? found = FindInList(subdivision.Children, query);
                    if (found != null)
                        return found;
                }
            }

            return null;
        }

        private static void FindAllInList(List<Subdivision> subdivisions, string query, List<Subdivision> result)
        {
            foreach (Subdivision subdivision in subdivisions)
            {
                if (subdivision.CodeCheck(query) || subdivision.NameCheck(query))
                    result.Add(subdivision);

                if (subdivision.Children != null)
                    FindAllInList(subdivision.Children, query, result);
            }
        }

        // ── Search ────────────────────────────────────────────────────────────

        /// <summary>
        /// Searches subdivisions using a rich request that supports multi-part queries,
        /// optional country scoping, and optional parent subdivision constraints.
        /// </summary>
        public SubdivisionSearchResult? Search(SubdivisionSearchRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Query))
                return null;

            if (request.CountryCode != null)
                return SearchInCountry(request.CountryCode, request);

            // No country specified – scan all countries and pick the highest score
            SubdivisionSearchResult? best = null;

            foreach (string countryCode in SubdivisionsList.Keys)
            {
                SubdivisionSearchResult? candidate = SearchInCountry(countryCode, request);

                if (candidate != null && (best == null || candidate.Score > best.Score))
                    best = candidate;
            }

            return best;
        }

        private static SubdivisionSearchResult? SearchInCountry(string countryCode, SubdivisionSearchRequest request)
        {
            List<Subdivision> roots;

            try { roots = SubdivisionsList[countryCode]; }
            catch { return null; }

            List<string> tokens = TokenizeQuery(request.Query);

            if (tokens.Count == 0)
                return null;

            SubdivisionSearchResult? best = null;

            // Try forward ordering
            SubdivisionSearchResult? forward = MatchChain(roots, tokens, countryCode);
            if (forward != null) best = forward;

            // Try reversed ordering (e.g. "Matn, Mount Lebanon" → try "Mount Lebanon, Matn" too)
            if (tokens.Count > 1)
            {
                List<string> reversed = [.. tokens];
                reversed.Reverse();
                SubdivisionSearchResult? rev = MatchChain(roots, reversed, countryCode);
                
                if (rev != null && (best == null || rev.Score > best.Score))
                    best = rev;
            }

            // Apply ParentSubdivisionCode filter
            if (best != null && request.ParentSubdivisionCode != null)
                if (!IsDescendantOf(roots, best.Primary?.Subdivision, request.ParentSubdivisionCode))
                    return null;

            return best;
        }

        // Splits the query on explicit delimiters; falls back to space-based splits
        // and picks the best chain across all possible binary splits.
        private static List<string> TokenizeQuery(string query)
        {
            char[] delimiters = [',', ';', '/', '|'];

            if (query.IndexOfAny(delimiters) >= 0)
                return [.. query.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                .Select(t => t.Trim())
                                .Where(t => t.Length > 0)];

            // Single word or space-separated – treat the whole thing as one token;
            // callers that need space-splits will call GenerateSpaceSplits separately.
            return [query.Trim()];
        }

        // Tries to match a chain of tokens starting from top-level roots.
        // For single-token queries also tries all space-split combinations.
        private static SubdivisionSearchResult? MatchChain(List<Subdivision> roots, List<string> tokens, string countryCode)
        {
            if (tokens.Count == 1)
            {
                string singleToken = tokens[0];
                SubdivisionSearchResult? best = null;

                // Try the token as a whole first
                foreach (var (sub, level, score) in FindAllWithLevels(roots, singleToken))
                {
                    SubdivisionSearchResult candidate = new()
                    {
                        CountryCode = countryCode,
                        Score = score,
                        Matches = [new SubdivisionMatch { Subdivision = sub, Level = level, MatchScore = score }]
                    };

                    if (best == null || candidate.Score > best.Score)
                        best = candidate;
                }

                // Also try space-splits so "Mount Lebanon" can resolve as one token
                // even when passed as a single query string with spaces
                foreach (List<string> split in GenerateSpaceSplits(singleToken))
                {
                    SubdivisionSearchResult? splitResult = MatchChainInChildren(roots, split, 0, [], countryCode);
                    if (splitResult != null && (best == null || splitResult.Score > best.Score))
                        best = splitResult;

                    List<string> rev = [.. split];
                    rev.Reverse();
                    SubdivisionSearchResult? revResult = MatchChainInChildren(roots, rev, 0, [], countryCode);
                    if (revResult != null && (best == null || revResult.Score > best.Score))
                        best = revResult;
                }

                return best;
            }

            return MatchChainInChildren(roots, tokens, 0, [], countryCode);
        }

        // Recursively resolves the next token in the chain, constraining each subsequent
        // token to children of the previously matched subdivision.
        private static SubdivisionSearchResult? MatchChainInChildren(
            List<Subdivision> scope,
            List<string> tokens,
            int tokenIndex,
            List<SubdivisionMatch> accumulated,
            string countryCode)
        {
            if (tokenIndex >= tokens.Count)
            {
                if (accumulated.Count == 0) return null;
                double avg = accumulated.Average(m => m.MatchScore);
                return new SubdivisionSearchResult { CountryCode = countryCode, Score = avg, Matches = [.. accumulated] };
            }

            string token = tokens[tokenIndex];
            SubdivisionSearchResult? best = null;

            foreach (var (sub, level, score) in FindAllWithLevels(scope, token, accumulated.Count + 1))
            {
                List<SubdivisionMatch> next = [.. accumulated, new SubdivisionMatch { Subdivision = sub, Level = level, MatchScore = score }];
                List<Subdivision> childScope = sub.Children ?? [];
                SubdivisionSearchResult? candidate = MatchChainInChildren(childScope, tokens, tokenIndex + 1, next, countryCode);

                if (candidate == null && tokenIndex == tokens.Count - 1)
                {
                    // Last token matched – close the result
                    double avg = next.Average(m => m.MatchScore);
                    candidate = new SubdivisionSearchResult { CountryCode = countryCode, Score = avg, Matches = next };
                }

                if (candidate != null && (best == null || candidate.Score > best.Score))
                    best = candidate;
            }

            return best;
        }

        // Returns all (subdivision, level, score) tuples within a scope list that match the token.
        private static List<(Subdivision Sub, int Level, double Score)> FindAllWithLevels(
            List<Subdivision> scope, string token, int baseLevel = 1)
        {
            List<(Subdivision, int, double)> results = [];

            foreach (Subdivision sub in scope)
            {
                double score = GetMatchScore(sub, token);
                if (score > 0)
                    results.Add((sub, baseLevel, score));

                if (sub.Children != null)
                    results.AddRange(FindAllWithLevels(sub.Children, token, baseLevel + 1));
            }

            return results;
        }

        // Returns the match confidence score for a single subdivision vs. one token.
        // 0 means no match.
        private static double GetMatchScore(Subdivision sub, string token)
        {
            token = token.Trim();
            if (token.Length == 0) return 0;

            // Exact code
            if (sub.CodeCheck(token)) return 1.0;

            // Exact English name
            if (sub.Name.Equals(token, StringComparison.OrdinalIgnoreCase)) return 0.95;

            // Exact local name
            if (sub.LocalName != null && sub.LocalName.Equals(token, StringComparison.OrdinalIgnoreCase)) return 0.9;

            // Arabic-script: direct local name match
            if (token.Any(c => c >= 0x0600 && c <= 0x06FF))
                return sub.LocalName != null && sub.LocalName.Contains(token, StringComparison.OrdinalIgnoreCase) ? 0.85 : 0;

            // Transliteration-normalized name match
            string normToken = Subdivision.NormalizeArabicTransliteration(token);
            if (normToken.Length >= 2)
            {
                if (Subdivision.NormalizeArabicTransliteration(sub.Name).Equals(normToken, StringComparison.Ordinal))
                    return 0.75;

                if (sub.LocalName != null &&
                    Subdivision.NormalizeArabicTransliteration(sub.LocalName).Equals(normToken, StringComparison.Ordinal))
                    return 0.70;
            }

            return 0;
        }

        // Generates all possible binary splits of a space-separated string.
        // e.g. "Mount Lebanon Matn" → [["Mount Lebanon", "Matn"], ["Mount", "Lebanon Matn"]]
        private static List<List<string>> GenerateSpaceSplits(string text)
        {
            List<List<string>> results = [];
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < words.Length; i++)
            {
                string left = string.Join(" ", words[..i]);
                string right = string.Join(" ", words[i..]);
                results.Add([left, right]);
            }

            return results;
        }

        // Returns true if the given subdivision is a descendant of (or equals) a subdivision
        // identified by parentCode anywhere in the roots tree.
        private static bool IsDescendantOf(List<Subdivision> roots, Subdivision? sub, string parentCode)
        {
            if (sub == null) return false;

            Subdivision? parent = FindSubdivisionByCode(roots, parentCode);

            if (parent == null) 
                return false;

            if (parent == sub) 
                return true;

            return IsDescendantOfNode(parent, sub);
        }

        private static bool IsDescendantOfNode(Subdivision ancestor, Subdivision target)
        {
            if (ancestor.Children == null) return false;

            foreach (Subdivision child in ancestor.Children)
            {
                if (child == target) 
                    return true;

                if (IsDescendantOfNode(child, target)) 
                    return true;
            }

            return false;
        }

        private static Subdivision? FindSubdivisionByCode(List<Subdivision> subdivisions, string code)
        {
            foreach (Subdivision sub in subdivisions)
            {
                if (sub.CodeCheck(code)) 
                    return sub;

                if (sub.Children != null)
                {
                    Subdivision? found = FindSubdivisionByCode(sub.Children, code);

                    if (found != null) 
                        return found;
                }
            }

            return null;
        }
    }
}
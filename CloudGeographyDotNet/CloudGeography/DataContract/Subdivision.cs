namespace AngryMonkey.Cloud.Geography;

public class Subdivision
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string LocalName { get; set; }
    public SubdivisionTypes Type { get; set; }
    public List<Subdivision>? Children { get; set; }

    internal bool CodeCheck(string code)
    {
        code = code.Trim().ToUpper();

        return Code == code;
    }

    internal bool NameCheck(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return false;

        query = query.Trim();

        // Arabic-script input: match directly against LocalName
        if (query.Any(c => c >= 0x0600 && c <= 0x06FF))
            return LocalName != null && LocalName.Equals(query, StringComparison.OrdinalIgnoreCase);

        // Exact match against Name or LocalName (case-insensitive)
        if (Name.Equals(query, StringComparison.OrdinalIgnoreCase) ||
            (LocalName != null && LocalName.Equals(query, StringComparison.OrdinalIgnoreCase)))
            return true;

        // Normalized Arabic-transliteration match
        string normalizedQuery = NormalizeArabicTransliteration(query);

        if (normalizedQuery.Length >= 2 &&
            NormalizeArabicTransliteration(Name).Equals(normalizedQuery, StringComparison.Ordinal))
            return true;

        if (LocalName != null && normalizedQuery.Length >= 2 &&
            NormalizeArabicTransliteration(LocalName).Equals(normalizedQuery, StringComparison.Ordinal))
            return true;

        return false;
    }

    // Strips common Arabic article prefixes (el-/al-/ash-/…), normalizes q→k,
    // then removes vowels and punctuation to produce a consonant skeleton
    // that tolerates spelling variants like "El Metn" == "Matn", "Beqaa" == "Bekaa".
    internal static string NormalizeArabicTransliteration(string name)
    {
        string normalized = name.Trim().ToLowerInvariant();

        // Remove apostrophes (straight and curly)
        normalized = normalized.Replace("'", string.Empty).Replace("\u2019", string.Empty);

        // Strip leading Arabic article prefixes
        string[] articles = ["ath-", "ash-", "ath ", "ash ", "al-", "el-", "as-", "at-", "az-", "ar-", "an-", "ad-", "al ", "el ", "as ", "at ", "az ", "ar ", "an ", "ad "];

        foreach (string article in articles)
            if (normalized.StartsWith(article))
            {
                normalized = normalized[article.Length..];
                break;
            }

        // Normalize q → k (e.g. Beqaa → Bekaa)
        normalized = normalized.Replace('q', 'k');

        // Strip vowels to produce consonant skeleton
        normalized = new string(normalized.Where(c => !"aeiou".Contains(c)).ToArray());

        // Remove spaces, hyphens, and dashes
        normalized = normalized.Replace(" ", string.Empty).Replace("-", string.Empty);

        return normalized;
    }
}

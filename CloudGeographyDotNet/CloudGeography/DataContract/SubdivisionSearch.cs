namespace AngryMonkey.Cloud.Geography;

/// <summary>
/// Input for <see cref="AngryMonkey.Cloud.CloudGeographyClient.SubdivisionsMethods.Search"/>.
/// Only <see cref="Query"/> is required; all other properties are optional filters.
/// </summary>
public class SubdivisionSearchRequest
{
    /// <summary>
    /// The search query. Can contain multiple parts separated by commas, semicolons,
    /// slashes, pipes, or spaces (e.g. "Mount Lebanon, Matn" or "LB Matn").
    /// Can be a code, English name, local name, or Arabic transliteration.
    /// </summary>
    public required string Query { get; set; }

    /// <summary>
    /// ISO 3166-1 alpha-2 country code (e.g. "LB"). When omitted the search
    /// spans all known countries and the highest-scoring result is returned.
    /// </summary>
    public string? CountryCode { get; set; }

    /// <summary>
    /// Optional parent subdivision code. When provided, only results whose deepest
    /// matched subdivision is a descendant of this code are accepted.
    /// </summary>
    public string? ParentSubdivisionCode { get; set; }
}

/// <summary>
/// A single matched subdivision within a <see cref="SubdivisionSearchResult"/>.
/// </summary>
public class SubdivisionMatch
{
    /// <summary>The matched subdivision.</summary>
    public required Subdivision Subdivision { get; set; }

    /// <summary>
    /// 1-based depth level in the hierarchy (1 = top-level, 2 = direct child, …).
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Confidence score for this individual token match (0–1).
    /// 1.0 = exact code, 0.95 = exact name, 0.9 = exact local name, ≤0.75 = transliteration.
    /// </summary>
    public double MatchScore { get; set; }
}

/// <summary>
/// Result returned by <see cref="AngryMonkey.Cloud.CloudGeographyClient.SubdivisionsMethods.Search"/>.
/// </summary>
public class SubdivisionSearchResult
{
    /// <summary>
    /// Overall confidence score (0–1), computed as the average of all
    /// <see cref="SubdivisionMatch.MatchScore"/> values in <see cref="Matches"/>.
    /// </summary>
    public double Score { get; set; }

    /// <summary>All matched subdivisions, ordered from broadest (highest level) to deepest.</summary>
    public List<SubdivisionMatch> Matches { get; set; } = [];

    /// <summary>
    /// Convenience accessor: the deepest (most specific) match, i.e. the last item in
    /// <see cref="Matches"/>.
    /// </summary>
    public SubdivisionMatch? Primary => Matches.Count > 0 ? Matches[^1] : null;

    /// <summary>ISO 3166-1 alpha-2 country code the result belongs to.</summary>
    public string? CountryCode { get; set; }
}

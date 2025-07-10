using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;

internal partial class BingModels
{
    internal class CountryRegion
    {
        [JsonPropertyName("isoCode")]
        public string? IsoCode { get; set; }
    }
}
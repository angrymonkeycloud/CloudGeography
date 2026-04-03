using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;

internal partial class BingModels
{
    internal class IPAddressResponse
    {
        [JsonPropertyName("countryRegion")]
        public CountryRegion? CountryRegion { get; set; }
        
        [JsonPropertyName("ipAddress")]
        public string? IpAddress { get; set; }
    }
}
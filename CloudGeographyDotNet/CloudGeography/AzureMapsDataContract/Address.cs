using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;

internal partial class BingModels
{
    internal class Address
    {
        [JsonPropertyName("buildingNumber")]
        public string? BuildingNumber { get; set; }
        
        [JsonPropertyName("streetNumber")]
        public string? StreetNumber { get; set; }
        
        [JsonPropertyName("routeNumbers")]
        public List<int>? RouteNumbers { get; set; }
        
        [JsonPropertyName("street")]
        public string? Street { get; set; }
        
        [JsonPropertyName("streetName")]
        public string? StreetName { get; set; }
        
        [JsonPropertyName("streetNameAndNumber")]
        public string? StreetNameAndNumber { get; set; }
        
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }
        
        [JsonPropertyName("countrySubdivision")]
        public string? CountrySubdivision { get; set; }
        
        [JsonPropertyName("countrySecondarySubdivision")]
        public string? CountrySecondarySubdivision { get; set; }
        
        [JsonPropertyName("municipality")]
        public string? Municipality { get; set; }
        
        [JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }
        
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("countryCodeISO3")]
        public string? CountryCodeISO3 { get; set; }
        
        [JsonPropertyName("freeformAddress")]
        public string? FreeformAddress { get; set; }
        
        [JsonPropertyName("boundingBox")]
        public AddressBoundingBox? BoundingBox { get; set; }
        
        [JsonPropertyName("localName")]
        public string? LocalName { get; set; }
    }
}
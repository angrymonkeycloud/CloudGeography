using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;
internal partial class BingModels
{
    // Note: This class is retained for backward compatibility,
    // but the AddressResponse.Results and AddressResult classes are now used instead
    internal class AddressReponseList
    {
        [JsonPropertyName("position")]
        public string? Position { get; set; }
        
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;

internal partial class BingModels
{
    internal class AddressSummary
    {
        [JsonPropertyName("queryTime")]
        public int QueryTime { get; set; }
        
        [JsonPropertyName("numResults")]
        public int NumResults { get; set; }
    }
}
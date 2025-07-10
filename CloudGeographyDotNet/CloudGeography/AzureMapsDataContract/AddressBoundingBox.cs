using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;

internal partial class BingModels
{
    internal class AddressBoundingBox
    {
        [JsonPropertyName("topLeftPoint")]
        public BoundingBoxPoint? TopLeftPoint { get; set; }
        
        [JsonPropertyName("btmRightPoint")]
        public BoundingBoxPoint? BottomRightPoint { get; set; }
    }
    
    internal class BoundingBoxPoint
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
        
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }
    }
}
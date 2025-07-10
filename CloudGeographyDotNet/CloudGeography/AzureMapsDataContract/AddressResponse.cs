using System.Text.Json;
using System.Text.Json.Serialization;

namespace AngryMonkey.Cloud.Geography;
internal partial class BingModels
{
    internal class AddressResponse
    {
        [JsonPropertyName("summary")]
        public AddressSummary? Summary { get; set; }

        [JsonPropertyName("addresses")]
        public List<AddressResult>? Results { get; set; }
    }

    internal class AddressResult
    {
        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        [JsonPropertyName("position")]
        [JsonConverter(typeof(PositionConverter))]
        public AddressPosition? Position { get; set; }
    }

    internal class AddressPosition
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        public override string ToString()
        {
            return $"{Latitude},{Longitude}";
        }
    }

    internal class PositionConverter : JsonConverter<AddressPosition>
    {
        public override AddressPosition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var positionString = reader.GetString();
                if (string.IsNullOrEmpty(positionString))
                    return null;

                var parts = positionString.Split(',');
                if (parts.Length == 2 && 
                    double.TryParse(parts[0], out double lat) && 
                    double.TryParse(parts[1], out double lon))
                {
                    return new AddressPosition { Latitude = lat, Longitude = lon };
                }
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                // Handle object format if needed for backward compatibility
                return JsonSerializer.Deserialize<AddressPosition>(ref reader, options);
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, AddressPosition value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
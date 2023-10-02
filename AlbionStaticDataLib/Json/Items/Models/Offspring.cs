using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Offspring
    {
        [JsonPropertyName("@chance")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Chance { get; set; }

        [JsonPropertyName("@amount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Amount { get; set; }
    }
}

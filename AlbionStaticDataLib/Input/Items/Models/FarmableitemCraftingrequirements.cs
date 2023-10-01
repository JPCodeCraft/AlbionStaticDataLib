using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class FarmableitemCraftingrequirements
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Silver { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Time { get; set; }

        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Swaptransaction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("playerfactionstanding")]
        public Playerfactionstanding Playerfactionstanding { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mistcitystanding")]
        public Mistcitystanding Mistcitystanding { get; set; }
    }
}

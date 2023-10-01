using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class JournalitemCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Time { get; set; }

        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Swaptransaction { get; set; }
    }
}

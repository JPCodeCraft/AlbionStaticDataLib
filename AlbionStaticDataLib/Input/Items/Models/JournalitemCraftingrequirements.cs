using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class JournalitemCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Time { get; set; }

        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Swaptransaction { get; set; }
    }
}

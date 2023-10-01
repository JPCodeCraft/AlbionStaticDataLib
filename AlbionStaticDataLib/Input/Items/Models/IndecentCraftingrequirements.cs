using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class IndecentCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("craftresource")]
        public FluffyCraftresource Craftresource { get; set; }
    }
}

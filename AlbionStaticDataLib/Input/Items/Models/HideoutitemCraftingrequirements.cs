using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class HideoutitemCraftingrequirements
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Amountcrafted { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("craftresource")]
        public List<ReplacementitemElement> Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Silver { get; set; }
    }
}

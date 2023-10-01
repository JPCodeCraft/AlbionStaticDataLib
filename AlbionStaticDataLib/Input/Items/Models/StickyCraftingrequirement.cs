using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class StickyCraftingrequirement
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Silver { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("craftresource")]
        public List<CraftingrequirementCraftresourceClass> Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Swaptransaction { get; set; }
    }
}

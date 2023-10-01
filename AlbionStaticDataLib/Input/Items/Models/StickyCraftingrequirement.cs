using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class StickyCraftingrequirement
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silver { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("craftresource")]
        public List<CraftingrequirementCraftresourceClass> Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Swaptransaction { get; set; }
    }
}

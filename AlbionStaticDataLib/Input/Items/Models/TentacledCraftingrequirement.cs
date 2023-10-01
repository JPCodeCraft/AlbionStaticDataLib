using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class TentacledCraftingrequirement
    {
        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Amountcrafted { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftresource")]
        public CraftingrequirementCraftresourceUnion? Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silver { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Craftingfocus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }
    }
}

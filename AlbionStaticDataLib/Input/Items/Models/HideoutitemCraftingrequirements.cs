using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class HideoutitemCraftingrequirements
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Amountcrafted { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("craftresource")]
        public List<ReplacementitemElement> Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silver { get; set; }
    }
}

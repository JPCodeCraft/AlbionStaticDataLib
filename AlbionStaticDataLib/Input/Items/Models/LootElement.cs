using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class LootElement
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemname")]
        public string Itemname { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemamount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Itemamount { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Weight { get; set; }

        [JsonPropertyName("@labourerfame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Labourerfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemenchantmentlevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Itemenchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silveramount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silveramount { get; set; }
    }
}

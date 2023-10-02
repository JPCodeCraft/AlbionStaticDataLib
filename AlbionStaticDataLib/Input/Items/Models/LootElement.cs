using AlbionStaticDataLib.Input.Shared.Converters;

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
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }

        [JsonPropertyName("@labourerfame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Labourerfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemenchantmentlevel")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int? Itemenchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silveramount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silveramount { get; set; }
    }
}

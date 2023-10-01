using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class LootElement
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemname")]
        public string Itemname { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemamount")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Itemamount { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Weight { get; set; }

        [JsonPropertyName("@labourerfame")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Labourerfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemenchantmentlevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Itemenchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silveramount")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Silveramount { get; set; }
    }
}

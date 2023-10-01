using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Product
    {
        [JsonPropertyName("@productiontime")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Productiontime { get; set; }

        [JsonPropertyName("@actionname")]
        public string Actionname { get; set; }

        [JsonPropertyName("@lootlist")]
        public string Lootlist { get; set; }

        [JsonPropertyName("@lootchance")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Lootchance { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Fame { get; set; }
    }
}

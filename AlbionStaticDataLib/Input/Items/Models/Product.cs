using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Product
    {
        [JsonPropertyName("@productiontime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Productiontime { get; set; }

        [JsonPropertyName("@actionname")]
        public string Actionname { get; set; }

        [JsonPropertyName("@lootlist")]
        public string Lootlist { get; set; }

        [JsonPropertyName("@lootchance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Lootchance { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Fame { get; set; }
    }
}

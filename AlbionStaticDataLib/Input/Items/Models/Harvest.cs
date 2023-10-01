using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Harvest
    {
        [JsonPropertyName("@growtime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Growtime { get; set; }

        [JsonPropertyName("@lootlist")]
        public string Lootlist { get; set; }

        [JsonPropertyName("@lootchance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Lootchance { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Fame { get; set; }

        [JsonPropertyName("seed")]
        public Offspring Seed { get; set; }
    }
}

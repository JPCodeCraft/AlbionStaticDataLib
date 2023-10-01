using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Harvest
    {
        [JsonPropertyName("@growtime")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Growtime { get; set; }

        [JsonPropertyName("@lootlist")]
        public string Lootlist { get; set; }

        [JsonPropertyName("@lootchance")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Lootchance { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Fame { get; set; }

        [JsonPropertyName("seed")]
        public Offspring Seed { get; set; }
    }
}

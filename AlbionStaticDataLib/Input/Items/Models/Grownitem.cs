using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Grownitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@growtime")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Growtime { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Fame { get; set; }

        [JsonPropertyName("offspring")]
        public Offspring Offspring { get; set; }
    }
}

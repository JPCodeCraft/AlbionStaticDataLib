using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Grownitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@growtime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Growtime { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Fame { get; set; }

        [JsonPropertyName("offspring")]
        public Offspring Offspring { get; set; }
    }
}

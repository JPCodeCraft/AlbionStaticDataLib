using System.Text.Json.Serialization;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

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

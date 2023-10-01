using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Resources.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class ResourceTier
    {
        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Value { get; set; }

        [JsonPropertyName("@resourcevalue")]
        public string Resourcevalue { get; set; }

        [JsonPropertyName("@famevalue")]
        public string Famevalue { get; set; }
    }
}

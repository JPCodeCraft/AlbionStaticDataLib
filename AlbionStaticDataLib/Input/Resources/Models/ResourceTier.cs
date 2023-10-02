using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class ResourceTier
    {
        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Value { get; set; }

        [JsonPropertyName("@resourcevalue")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Resourcevalue { get; set; }

        [JsonPropertyName("@famevalue")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Famevalue { get; set; }
    }
}

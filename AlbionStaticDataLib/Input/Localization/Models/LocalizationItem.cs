using AlbionStaticDataLib.Input.Localization.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Localization.Models
{
    public class LocalizationItem
    {
        [JsonPropertyName("LocalizationNameVariable")]
        public string LocalizationNameVariable { get; set; }

        [JsonPropertyName("LocalizationDescriptionVariable")]
        public string LocalizationDescriptionVariable { get; set; }

        [JsonPropertyName("LocalizedNames")]
        public Localized LocalizedNames { get; set; }

        [JsonPropertyName("LocalizedDescriptions")]
        public Localized LocalizedDescriptions { get; set; }

        [JsonPropertyName("Index")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Index { get; set; }

        [JsonPropertyName("UniqueName")]
        public string UniqueName { get; set; }
    }
}

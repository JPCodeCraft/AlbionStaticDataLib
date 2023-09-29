using AlbionStaticDataLib.Input.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Localization.Models
{
    public class ItemLocalization
    {
        [JsonPropertyName("LocalizationNameVariable")]
        public string LocalizationNameVariable { get; set; }

        [JsonPropertyName("LocalizationDescriptionVariable")]
        public string LocalizationDescriptionVariable { get; set; }

        [JsonPropertyName("LocalizedNames")]
        public LocalizedData LocalizedNames { get; set; }

        [JsonPropertyName("LocalizedDescriptions")]
        public LocalizedData LocalizedDescriptions { get; set; }

        [JsonPropertyName("UniqueName")]
        public string UniqueName { get; set; }

        [JsonConverter(typeof(StringToIntConverter))]
        [JsonPropertyName("Index")]
        public int Index { get; set; }
    }
}

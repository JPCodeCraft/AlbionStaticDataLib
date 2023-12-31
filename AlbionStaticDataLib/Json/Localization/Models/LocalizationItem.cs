﻿using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Localization.Models
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
        [JsonConverter(typeof(StringToLongConverter))]
        public long Index { get; set; }

        [JsonPropertyName("UniqueName")]
        public string UniqueName { get; set; }
    }
}

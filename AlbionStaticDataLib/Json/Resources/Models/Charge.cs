﻿using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class Charge
    {
        [JsonPropertyName("@level")]
        public string Level { get; set; }

        [JsonPropertyName("@gfxstate")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Gfxstate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawnfactormin")]
        public string Respawnfactormin { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawnfactormax")]
        public string Respawnfactormax { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawncharges")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Respawncharges { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@yield")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Yield { get; set; }
    }
}

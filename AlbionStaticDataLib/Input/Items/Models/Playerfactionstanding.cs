﻿using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Enums;
using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Playerfactionstanding
    {
        [JsonPropertyName("@faction")]
        public Faction Faction { get; set; }

        [JsonPropertyName("@minstanding")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Minstanding { get; set; }
    }
}

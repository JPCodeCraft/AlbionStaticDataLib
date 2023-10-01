﻿using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class PurpleCraftspell
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@slots")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Slots { get; set; }
    }
}
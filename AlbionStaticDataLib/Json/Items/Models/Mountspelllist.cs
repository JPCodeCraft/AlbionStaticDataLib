﻿using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Mountspelllist
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mountspell")]
        [JsonConverter(typeof(SingleOrArrayConverter<MountspellElement>))]
        public List<MountspellElement>? Mountspells { get; set; }
    }
}

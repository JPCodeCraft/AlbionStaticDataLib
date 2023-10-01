﻿using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class ItemsRoot
    {
        [JsonPropertyName("?xml")]
        public Xml Xml { get; set; }

        [JsonPropertyName("items")]
        public Items Items { get; set; }
    }
}

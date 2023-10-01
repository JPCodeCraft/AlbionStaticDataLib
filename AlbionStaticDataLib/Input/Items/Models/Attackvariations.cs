﻿using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Attackvariations
    {
        [JsonPropertyName("@attackchaintime")]
        public string Attackchaintime { get; set; }

        [JsonPropertyName("attack")]
        public List<Attack> Attack { get; set; }
    }
}

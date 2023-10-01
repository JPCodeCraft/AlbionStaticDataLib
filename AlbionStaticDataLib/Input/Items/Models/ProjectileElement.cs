using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class ProjectileElement
    {
        [JsonPropertyName("@prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("@startsocket")]
        public Startsocket Startsocket { get; set; }

        [JsonPropertyName("@hitsocket")]
        public Socket Hitsocket { get; set; }

        [JsonPropertyName("@flyspeed")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Flyspeed { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("impactvfx")]
        public Impactvfx Impactvfx { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@timeoffset")]
        public string Timeoffset { get; set; }
    }
}

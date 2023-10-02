using AlbionStaticDataLib.Input.Shared.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class ProjectileElement
    {
        [JsonPropertyName("@prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("@startsocket")]
        public string Startsocket { get; set; }

        [JsonPropertyName("@hitsocket")]
        public string Hitsocket { get; set; }

        [JsonPropertyName("@flyspeed")]
        [JsonConverter(typeof(StringToLongConverter))]
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

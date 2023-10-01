using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Mountskin
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@prefabname")]
        public string Prefabname { get; set; }

        [JsonPropertyName("@prefabscaling")]
        public string Prefabscaling { get; set; }

        [JsonPropertyName("@despawneffect")]
        public Despawneffect Despawneffect { get; set; }

        [JsonPropertyName("@despawneffectscaling")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Despawneffectscaling { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@vfxAddonKeyword")]
        public string VfxAddonKeyword { get; set; }

        [JsonPropertyName("SocketPreset")]
        public AudioInfo SocketPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetVfxPreset")]
        public AudioInfo AssetVfxPreset { get; set; }

        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FootStepVfxPreset")]
        public AudioInfo FootStepVfxPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@nametagoffset")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Nametagoffset { get; set; }
    }
}

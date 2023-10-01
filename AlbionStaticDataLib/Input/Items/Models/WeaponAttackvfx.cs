using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class WeaponAttackvfx
    {
        [JsonPropertyName("@prefab")]
        public Prefab Prefab { get; set; }

        [JsonPropertyName("@target")]
        public Target Target { get; set; }
    }
}

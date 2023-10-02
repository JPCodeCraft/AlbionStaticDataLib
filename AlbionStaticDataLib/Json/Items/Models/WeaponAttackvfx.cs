using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class WeaponAttackvfx
    {
        [JsonPropertyName("@prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("@target")]
        public string Target { get; set; }
    }
}

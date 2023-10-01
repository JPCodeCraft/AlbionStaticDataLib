using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class AttackvfxElement
    {
        [JsonPropertyName("@prefab")]
        public Prefab Prefab { get; set; }

        [JsonPropertyName("@socket")]
        public Socket Socket { get; set; }

        [JsonPropertyName("@constraintpreset")]
        public Constraintpreset Constraintpreset { get; set; }

        [JsonPropertyName("@target")]
        public Target Target { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@visibility")]
        public Visibility? Visibility { get; set; }
    }
}

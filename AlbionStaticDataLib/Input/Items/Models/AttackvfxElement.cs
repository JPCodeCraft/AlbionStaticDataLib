using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class AttackvfxElement
    {
        [JsonPropertyName("@prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("@socket")]
        public string Socket { get; set; }

        [JsonPropertyName("@constraintpreset")]
        public string Constraintpreset { get; set; }

        [JsonPropertyName("@target")]
        public string Target { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@visibility")]
        public string? Visibility { get; set; }
    }
}

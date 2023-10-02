using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Impactvfx
    {
        [JsonPropertyName("@prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("@impactsocket")]
        public string Impactsocket { get; set; }
    }
}

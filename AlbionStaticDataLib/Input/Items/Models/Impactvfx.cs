using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Impactvfx
    {
        [JsonPropertyName("@prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("@impactsocket")]
        public Socket Impactsocket { get; set; }
    }
}

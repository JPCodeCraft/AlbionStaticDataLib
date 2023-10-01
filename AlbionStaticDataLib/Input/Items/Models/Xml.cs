using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Xml
    {
        [JsonPropertyName("@version")]
        public string Version { get; set; }

        [JsonPropertyName("@encoding")]
        public string Encoding { get; set; }
    }
}

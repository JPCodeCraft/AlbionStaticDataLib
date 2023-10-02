using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Xml
    {
        [JsonPropertyName("@version")]
        public string Version { get; set; }

        [JsonPropertyName("@encoding")]
        public string Encoding { get; set; }
    }
}

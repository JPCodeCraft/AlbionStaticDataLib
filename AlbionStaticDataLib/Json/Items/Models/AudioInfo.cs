using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class AudioInfo
    {
        [JsonPropertyName("@name")]
        public string Name { get; set; }
    }
}

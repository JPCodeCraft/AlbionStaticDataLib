using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Resources
    {
        [JsonPropertyName("Resource")]
        public List<Resource> Resource { get; set; }
    }
}

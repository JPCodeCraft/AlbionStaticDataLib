using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class Resources
    {
        [JsonPropertyName("Resource")]
        public List<Resource> Resource { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class ResourcesRoot
    {
        [JsonPropertyName("?xml")]
        public Xml Xml { get; set; }

        [JsonPropertyName("AO-Resources")]
        public AoResources AoResources { get; set; }
    }
}

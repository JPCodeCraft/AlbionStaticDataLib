using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Resource
    {
        [JsonPropertyName("@name")]
        public string Name { get; set; }

        [JsonPropertyName("ResourceTier")]
        public List<ResourceTier> ResourceTier { get; set; }
    }
}

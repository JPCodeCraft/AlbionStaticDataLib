using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class AoResources
    {
        [JsonPropertyName("@xmlns:xsi")]
        public Uri XmlnsXsi { get; set; }

        [JsonPropertyName("@xsi:noNamespaceSchemaLocation")]
        public string XsiNoNamespaceSchemaLocation { get; set; }

        [JsonPropertyName("Resources")]
        public Resources Resources { get; set; }

        [JsonPropertyName("Harvestables")]
        public Harvestables Harvestables { get; set; }
    }
}

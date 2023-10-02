using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class Harvestables
    {
        [JsonPropertyName("Harvestable")]
        public List<Harvestable> Harvestable { get; set; }
    }
}

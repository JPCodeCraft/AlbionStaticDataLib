using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Harvestables
    {
        [JsonPropertyName("Harvestable")]
        public List<Harvestable> Harvestable { get; set; }
    }
}

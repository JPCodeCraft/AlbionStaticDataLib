using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class ToolModifier
    {
        [JsonPropertyName("Modifier")]
        public List<Modifier> Modifier { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class ToolModifier
    {
        [JsonPropertyName("Modifier")]
        public List<Modifier> Modifier { get; set; }
    }
}

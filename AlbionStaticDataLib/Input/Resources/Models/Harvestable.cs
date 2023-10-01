using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Harvestable
    {
        [JsonPropertyName("@name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@resource")]
        public ResourceEnum? Resource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ToolModifier")]
        public ToolModifier ToolModifier { get; set; }

        [JsonPropertyName("Tier")]
        public TierUnion Tier { get; set; }
    }
}

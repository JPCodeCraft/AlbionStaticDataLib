namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Harvestable
    {
        [JsonPropertyName("@name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@resource")]
        public ResourceTypeEnum? Resource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ToolModifier")]
        public ToolModifier ToolModifier { get; set; }

        [JsonPropertyName("Tier")]
        [JsonConverter(typeof(SingleOrArrayConverter<TierElement>))]
        public List<TierElement> Tier { get; set; }
    }
}

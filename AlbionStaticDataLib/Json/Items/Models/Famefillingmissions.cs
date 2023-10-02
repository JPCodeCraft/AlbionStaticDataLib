namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Famefillingmissions
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("gatherfame")]
        public Fame Gatherfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftitemfame")]
        public Fame Craftitemfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("killmobfame")]
        public Fame Killmobfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fameearned")]
        public Fame Fameearned { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fishingfame")]
        public Fame Fishingfame { get; set; }
    }
}

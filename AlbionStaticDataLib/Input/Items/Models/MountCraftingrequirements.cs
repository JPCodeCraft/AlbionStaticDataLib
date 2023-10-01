using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class MountCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Craftingfocus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftresource")]
        public FluffyCraftresource? Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@gold")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Gold { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@compensategold")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Compensategold { get; set; }
    }
}

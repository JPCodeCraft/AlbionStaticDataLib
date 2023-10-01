using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class StickyCraftingrequirements
    {
        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Craftingfocus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftresource")]
        public PurpleCraftresource? Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@gold")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Gold { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Silver { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Amountcrafted { get; set; }
    }
}

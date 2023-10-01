using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class KilltrophyCraftingrequirements
    {
        [JsonPropertyName("@gold")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Gold { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Time { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Fame
    {
        [JsonPropertyName("@mintier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Mintier { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Value { get; set; }

        [JsonPropertyName("validitem")]
        public List<Validitem> Validitem { get; set; }
    }
}

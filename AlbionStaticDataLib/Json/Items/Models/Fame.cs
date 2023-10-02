using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Fame
    {
        [JsonPropertyName("@mintier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Mintier { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Value { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("validitem")]
        public List<Validitem>? Validitem { get; set; }
    }
}

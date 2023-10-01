using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Fame
    {
        [JsonPropertyName("@mintier")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Mintier { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Value { get; set; }

        [JsonPropertyName("validitem")]
        public List<Validitem> Validitem { get; set; }
    }
}

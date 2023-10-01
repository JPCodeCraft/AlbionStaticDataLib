using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class TentacledCraftspell
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@slots")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Slots { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tag")]
        public Tag? Tag { get; set; }
    }
}

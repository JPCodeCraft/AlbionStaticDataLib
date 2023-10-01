using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Fameearned
    {
        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Value { get; set; }
    }
}

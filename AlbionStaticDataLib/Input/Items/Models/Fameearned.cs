using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Fameearned
    {
        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Value { get; set; }
    }
}

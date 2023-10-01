using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Resources.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class RareState
    {
        [JsonPropertyName("@state")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long State { get; set; }

        [JsonPropertyName("@item")]
        public string Item { get; set; }
    }
}

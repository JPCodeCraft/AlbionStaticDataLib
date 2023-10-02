using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class RareState
    {
        [JsonPropertyName("@state")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long State { get; set; }

        [JsonPropertyName("@item")]
        public string Item { get; set; }
    }
}

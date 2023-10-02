using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class ReplacementitemElement
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@count")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Count { get; set; }
    }
}

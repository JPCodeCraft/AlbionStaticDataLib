using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Shopsubcategory
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Value { get; set; }
    }
}

using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Shopsubcategory
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Value { get; set; }
    }
}

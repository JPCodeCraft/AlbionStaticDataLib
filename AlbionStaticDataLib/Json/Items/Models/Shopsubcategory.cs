using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Shopsubcategory
    {
        [JsonPropertyName("@id")]
        public ShopsubcategoryName Id { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Value { get; set; }
    }
}

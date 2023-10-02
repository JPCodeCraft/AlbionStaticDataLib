using AlbionStaticDataLib.Input.Items.Enums;
using AlbionStaticDataLib.Input.Shared.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

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

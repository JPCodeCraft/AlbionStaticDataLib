using AlbionStaticDataLib.Input.Items.Enums;
using AlbionStaticDataLib.Input.Shared.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Shopcategory
    {
        [JsonPropertyName("@id")]
        public ShopCategoryName Id { get; set; }

        [JsonPropertyName("@value")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Value { get; set; }

        [JsonPropertyName("shopsubcategory")]
        public List<Shopsubcategory> Shopsubcategory { get; set; }
    }
}

using AlbionStaticDataLib.Input.Items.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Shopcategory
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("@value")]
        public ShopCategoryName Name { get; set; }

        [JsonPropertyName("shopsubcategory")]
        public List<Shopsubcategory> Shopsubcategory { get; set; }
    }
}

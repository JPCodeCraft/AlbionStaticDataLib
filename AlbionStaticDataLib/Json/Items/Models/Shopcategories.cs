using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Shopcategories
    {
        [JsonPropertyName("shopcategory")]
        public List<Shopcategory> Shopcategory { get; set; }
    }
}

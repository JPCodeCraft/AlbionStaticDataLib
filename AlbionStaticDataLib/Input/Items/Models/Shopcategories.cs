using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Shopcategories
    {
        [JsonPropertyName("shopcategory")]
        public List<Shopcategory> Shopcategory { get; set; }
    }
}

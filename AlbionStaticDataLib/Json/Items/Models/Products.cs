using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Products
    {
        [JsonPropertyName("product")]
        public Product Product { get; set; }
    }
}

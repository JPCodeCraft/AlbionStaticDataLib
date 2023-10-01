using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Products
    {
        [JsonPropertyName("product")]
        public Product Product { get; set; }
    }
}

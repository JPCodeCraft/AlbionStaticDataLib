using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Acceptedfood
    {
        [JsonPropertyName("@foodcategory")]
        public Foodcategory Foodcategory { get; set; }
    }
}

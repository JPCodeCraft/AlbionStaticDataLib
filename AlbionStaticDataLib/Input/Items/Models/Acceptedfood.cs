using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Acceptedfood
    {
        [JsonPropertyName("@foodcategory")]
        public Foodcategory Foodcategory { get; set; }
    }
}

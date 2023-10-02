using System.Text.Json.Serialization;
using AlbionStaticDataLib.Json.Items.Enums;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Acceptedfood
    {
        [JsonPropertyName("@foodcategory")]
        public Foodcategory Foodcategory { get; set; }
    }
}

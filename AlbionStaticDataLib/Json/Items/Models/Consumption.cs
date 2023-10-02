using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Consumption
    {
        [JsonPropertyName("food")]
        public Food Food { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Canharvest
    {
        [JsonPropertyName("@resourcetype")]
        public CanharvestResourcetype Resourcetype { get; set; }
    }
}

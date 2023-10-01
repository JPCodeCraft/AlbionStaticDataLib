using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Validitem
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Validitem
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }
    }
}

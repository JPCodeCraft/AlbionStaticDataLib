using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class FluffyCraftspell
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }
    }
}

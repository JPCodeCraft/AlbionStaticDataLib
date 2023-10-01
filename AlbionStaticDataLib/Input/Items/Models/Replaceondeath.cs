using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Replaceondeath
    {
        [JsonPropertyName("replacementitem")]
        public ReplacementitemElement Replacementitem { get; set; }
    }
}

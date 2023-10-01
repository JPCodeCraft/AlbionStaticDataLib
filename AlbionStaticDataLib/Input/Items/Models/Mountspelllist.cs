using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Mountspelllist
    {
        [JsonPropertyName("mountspell")]
        public MountspellUnion Mountspell { get; set; }
    }
}

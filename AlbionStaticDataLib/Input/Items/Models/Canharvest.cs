using AlbionStaticDataLib.Input.Shared.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Canharvest
    {
        [JsonPropertyName("@resourcetype")]
        public ResourceType Resourcetype { get; set; }
    }
}

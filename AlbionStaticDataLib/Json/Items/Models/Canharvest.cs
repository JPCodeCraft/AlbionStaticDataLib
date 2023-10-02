using AlbionStaticDataLib.Json.Shared.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Canharvest
    {
        [JsonPropertyName("@resourcetype")]
        public ResourceType Resourcetype { get; set; }
    }
}

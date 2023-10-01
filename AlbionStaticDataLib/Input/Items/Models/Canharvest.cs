using AlbionStaticDataLib.Input.Shared;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Canharvest
    {
        [JsonPropertyName("@resourcetype")]
        public ResourceTypeEnum Resourcetype { get; set; }
    }
}

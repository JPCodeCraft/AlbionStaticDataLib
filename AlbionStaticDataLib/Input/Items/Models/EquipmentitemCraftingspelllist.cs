using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class EquipmentitemCraftingspelllist
    {
        [JsonPropertyName("craftspell")]
        public StickyCraftspell Craftspell { get; set; }
    }
}

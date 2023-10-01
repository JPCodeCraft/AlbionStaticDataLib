using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class WeaponCraftingspelllist
    {
        [JsonPropertyName("craftspell")]
        public IndigoCraftspell Craftspell { get; set; }
    }
}

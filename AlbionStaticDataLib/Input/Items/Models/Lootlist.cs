using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Lootlist
    {
        [JsonPropertyName("loot")]
        public LootUnion Loot { get; set; }
    }
}

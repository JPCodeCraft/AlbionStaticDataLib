using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Lootlist
    {
        [JsonPropertyName("loot")]
        [JsonConverter(typeof(SingleOrArrayConverter<LootElement>))]
        public List<LootElement> Loot { get; set; }
    }
}

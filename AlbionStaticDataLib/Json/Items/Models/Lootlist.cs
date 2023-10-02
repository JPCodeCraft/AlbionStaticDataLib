using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Lootlist
    {
        [JsonPropertyName("loot")]
        [JsonConverter(typeof(SingleOrArrayConverter<LootElement>))]
        public List<LootElement> Loot { get; set; }
    }
}

using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Craftingspelllist
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftspell")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftspell>))]
        public List<Craftspell> Craftingspells { get; set; }
    }
}

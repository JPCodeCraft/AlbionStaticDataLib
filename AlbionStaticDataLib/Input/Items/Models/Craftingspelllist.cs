namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Craftingspelllist
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftspell")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftspell>))]
        public List<Craftspell> Craftingspells { get; set; }
    }
}

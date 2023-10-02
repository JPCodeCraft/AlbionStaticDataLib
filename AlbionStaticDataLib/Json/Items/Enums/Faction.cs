namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Faction>))]
    public enum Faction { Caerleon, Forest, Highland, Mountain, Steppe, Swamp };
}

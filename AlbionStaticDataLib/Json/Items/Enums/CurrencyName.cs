namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<CurrencyName>))]
    public enum CurrencyName
    {
        Faction_Caerleon, Faction_Forest, Faction_Highland, Faction_Mountain,
        Faction_Steppe, Faction_Swamp, Favor
    };
}

namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<FarmableItemKind>))]
    public enum FarmableItemKind { Animal, Plant };
}

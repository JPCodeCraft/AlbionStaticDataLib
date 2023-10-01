namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<FarmableItemKind>))]
    public enum FarmableItemKind { Animal, Plant };
}

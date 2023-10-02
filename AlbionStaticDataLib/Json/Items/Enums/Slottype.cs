namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Slottype>))]
    public enum Slottype { Food, Potion, Mount, Armor, Bag, Cape, Head, Mainhand, Offhand, Shoes };
}

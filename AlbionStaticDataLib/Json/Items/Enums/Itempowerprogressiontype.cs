namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Itempowerprogressiontype>))]
    public enum Itempowerprogressiontype
    {
        Armor, Bag, Cape, Head, Mainhand, Offhand, Shoes,
        Avalonshield, Book, Cane, Censer, Demonskull, Horn, Lamp, Orb, Shield, Skullshield,
        Spikedshield, Talisman, Torch, Totem, Towershield
    };
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<ShopCategoryName>))]
    public enum ShopCategoryName
    {
        Melee,
        Magic,
        Ranged,
        Offhand,
        Armor,
        Accessories,
        Mounts,
        Gatherergear,
        Tools,
        Consumables,
        Skillbooks,
        Resources,
        Cityresources,
        Artefacts,
        Materials,
        Token,
        Farmables,
        Products,
        Luxurygoods,
        Trophies,
        Furniture,
        Labourers,
        Other,
    }
}

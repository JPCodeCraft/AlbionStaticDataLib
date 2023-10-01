using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<ShopCategoryName>))]
    public enum ShopCategoryName
    {
        Consumables,
        Skillbooks,
        Artefacts,
        Cityresources,
        Luxurygoods,
        Materials,
        Other,
        Products,
        Resources,
        Token,
        Accessories,
        Armor,
        Gatherergear,
        Melee,
        Offhand,
        Farmables,
        Furniture,
        Trophies,
        Labourers,
        Mounts
    }
}

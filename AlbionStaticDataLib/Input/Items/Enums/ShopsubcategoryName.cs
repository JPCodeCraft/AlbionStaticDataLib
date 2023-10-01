using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<ShopsubcategoryName>))]
    public enum ShopsubcategoryName
    {
        Cooked, Fish, FishingBait, Potion, Vanity,
        CrystalLeague,
        Animals, Seed,
        Journal,
        ArcaneStaff, Axe, Bow, Crossbow, CurseStaff, Dagger, DemolitionHammer,
        FireStaff, Fishing, FrostStaff, Hammer, HolyStaff, Knuckles, Mace,
        NatureStaff, Pickaxe, Quarterstaff, Sickle, SkinningKnife, Spear,
        StoneHammer, Sword, Tools, WoodAxe
    }
}

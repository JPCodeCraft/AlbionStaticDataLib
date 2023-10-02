namespace AlbionStaticDataLib.Json.Items.Models

{
    [JsonConverter(typeof(JsonStringEnumConverter<Craftingcategory>))]
    public enum Craftingcategory
    {
        food, wood, rock, ore, hide, fiber, potion, offhand, cape, bag, plate_helmet,
        plate_armor, plate_shoes, leather_helmet, leather_armor, leather_shoes, cloth_helmet,
        cloth_armor, cloth_shoes, gatherergear, tools, bow, crossbow, cursestaff,
        firestaff, froststaff, arcanestaff, holystaff, naturestaff, dagger, spear,
        axe, sword, quarterstaff, hammer, mace, knuckles
    };
}

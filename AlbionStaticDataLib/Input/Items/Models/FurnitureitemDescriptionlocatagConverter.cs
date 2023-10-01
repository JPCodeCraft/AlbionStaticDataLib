using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FurnitureitemDescriptionlocatagConverter : JsonConverter<FurnitureitemDescriptionlocatag>
    {
        public override bool CanConvert(Type t) => t == typeof(FurnitureitemDescriptionlocatag);

        public override FurnitureitemDescriptionlocatag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "@ITEMS_FURNITUREITEM_PLAYERISLAND_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemPlayerislandDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_FIBER_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyFiberDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_FISH_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyFishDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_GENERAL_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyGeneralDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_HIDE_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyHideDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_MERCENARY_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyMercenaryDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_ORE_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyOreDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_ROCK_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyRockDesc;
                case "@ITEMS_FURNITUREITEM_TROPHY_WOOD_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyWoodDesc;
                case "@ITEMS_UNIQUE_FURNITUREITEM_ADC_GLASS_SPHERE_A_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsUniqueFurnitureitemAdcGlassSphereADesc;
                case "@ITEMS_UNIQUE_FURNITUREITEM_OUTDOORS_DESC":
                    return FurnitureitemDescriptionlocatag.ItemsUniqueFurnitureitemOutdoorsDesc;
            }
            throw new Exception("Cannot unmarshal type FurnitureitemDescriptionlocatag");
        }

        public override void Write(Utf8JsonWriter writer, FurnitureitemDescriptionlocatag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemPlayerislandDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_PLAYERISLAND_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyFiberDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_FIBER_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyFishDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_FISH_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyGeneralDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_GENERAL_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyHideDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_HIDE_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyMercenaryDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_MERCENARY_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyOreDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_ORE_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyRockDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_ROCK_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsFurnitureitemTrophyWoodDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_FURNITUREITEM_TROPHY_WOOD_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsUniqueFurnitureitemAdcGlassSphereADesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_UNIQUE_FURNITUREITEM_ADC_GLASS_SPHERE_A_DESC", options);
                    return;
                case FurnitureitemDescriptionlocatag.ItemsUniqueFurnitureitemOutdoorsDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_UNIQUE_FURNITUREITEM_OUTDOORS_DESC", options);
                    return;
            }
            throw new Exception("Cannot marshal type FurnitureitemDescriptionlocatag");
        }

        public static readonly FurnitureitemDescriptionlocatagConverter Singleton = new FurnitureitemDescriptionlocatagConverter();
    }
}

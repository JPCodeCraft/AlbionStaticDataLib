using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FurnitureitemUicraftsoundstartConverter : JsonConverter<FurnitureitemUicraftsoundstart>
    {
        public override bool CanConvert(Type t) => t == typeof(FurnitureitemUicraftsoundstart);

        public override FurnitureitemUicraftsoundstart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_flour_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftFlourStart;
                case "Play_ui_action_craft_food_firm_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftFoodFirmStart;
                case "Play_ui_action_craft_food_fry_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftFoodFryStart;
                case "Play_ui_action_craft_food_liquid_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftFoodLiquidStart;
                case "Play_ui_action_craft_meat_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftMeatStart;
                case "Play_ui_action_craft_refine_fiber_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineFiberStart;
                case "Play_ui_action_craft_refine_hide_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineHideStart;
                case "Play_ui_action_craft_refine_ore_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineOreStart;
                case "Play_ui_action_craft_refine_stone_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineStoneStart;
                case "Play_ui_action_craft_refine_wood_start":
                    return FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineWoodStart;
            }
            throw new Exception("Cannot unmarshal type FurnitureitemUicraftsoundstart");
        }

        public override void Write(Utf8JsonWriter writer, FurnitureitemUicraftsoundstart value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftFlourStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_flour_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftFoodFirmStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_firm_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftFoodFryStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_fry_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftFoodLiquidStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_liquid_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftMeatStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_meat_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineFiberStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_fiber_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineHideStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_hide_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineOreStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_ore_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineStoneStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_stone_start", options);
                    return;
                case FurnitureitemUicraftsoundstart.PlayUiActionCraftRefineWoodStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_wood_start", options);
                    return;
            }
            throw new Exception("Cannot marshal type FurnitureitemUicraftsoundstart");
        }

        public static readonly FurnitureitemUicraftsoundstartConverter Singleton = new FurnitureitemUicraftsoundstartConverter();
    }
}

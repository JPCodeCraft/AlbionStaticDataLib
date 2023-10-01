using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FurnitureitemUicraftsoundfinishConverter : JsonConverter<FurnitureitemUicraftsoundfinish>
    {
        public override bool CanConvert(Type t) => t == typeof(FurnitureitemUicraftsoundfinish);

        public override FurnitureitemUicraftsoundfinish Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_flour_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftFlourFinish;
                case "Play_ui_action_craft_food_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftFoodFinish;
                case "Play_ui_action_craft_meat_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftMeatFinish;
                case "Play_ui_action_craft_refine_fiber_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineFiberFinish;
                case "Play_ui_action_craft_refine_hide_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineHideFinish;
                case "Play_ui_action_craft_refine_ore_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineOreFinish;
                case "Play_ui_action_craft_refine_stone_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineStoneFinish;
                case "Play_ui_action_craft_refine_wood_finish":
                    return FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineWoodFinish;
            }
            throw new Exception("Cannot unmarshal type FurnitureitemUicraftsoundfinish");
        }

        public override void Write(Utf8JsonWriter writer, FurnitureitemUicraftsoundfinish value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftFlourFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_flour_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftFoodFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftMeatFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_meat_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineFiberFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_fiber_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineHideFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_hide_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineOreFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_ore_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineStoneFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_stone_finish", options);
                    return;
                case FurnitureitemUicraftsoundfinish.PlayUiActionCraftRefineWoodFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_refine_wood_finish", options);
                    return;
            }
            throw new Exception("Cannot marshal type FurnitureitemUicraftsoundfinish");
        }

        public static readonly FurnitureitemUicraftsoundfinishConverter Singleton = new FurnitureitemUicraftsoundfinishConverter();
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EquipmentitemUicraftsoundfinishConverter : JsonConverter<EquipmentitemUicraftsoundfinish>
    {
        public override bool CanConvert(Type t) => t == typeof(EquipmentitemUicraftsoundfinish);

        public override EquipmentitemUicraftsoundfinish Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_cloth_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftClothFinish;
                case "Play_ui_action_craft_leather_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftLeatherFinish;
                case "Play_ui_action_craft_magic_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftMagicFinish;
                case "Play_ui_action_craft_metal_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftMetalFinish;
                case "Play_ui_action_craft_plate_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftPlateFinish;
                case "Play_ui_action_craft_tool_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftToolFinish;
                case "Play_ui_action_craft_wood_finish":
                    return EquipmentitemUicraftsoundfinish.PlayUiActionCraftWoodFinish;
            }
            throw new Exception("Cannot unmarshal type EquipmentitemUicraftsoundfinish");
        }

        public override void Write(Utf8JsonWriter writer, EquipmentitemUicraftsoundfinish value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftClothFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_cloth_finish", options);
                    return;
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftLeatherFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_leather_finish", options);
                    return;
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftMagicFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_magic_finish", options);
                    return;
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftMetalFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_metal_finish", options);
                    return;
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftPlateFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_plate_finish", options);
                    return;
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftToolFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_tool_finish", options);
                    return;
                case EquipmentitemUicraftsoundfinish.PlayUiActionCraftWoodFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_wood_finish", options);
                    return;
            }
            throw new Exception("Cannot marshal type EquipmentitemUicraftsoundfinish");
        }

        public static readonly EquipmentitemUicraftsoundfinishConverter Singleton = new EquipmentitemUicraftsoundfinishConverter();
    }
}

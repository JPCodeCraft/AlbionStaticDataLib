using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EquipmentitemUicraftsoundstartConverter : JsonConverter<EquipmentitemUicraftsoundstart>
    {
        public override bool CanConvert(Type t) => t == typeof(EquipmentitemUicraftsoundstart);

        public override EquipmentitemUicraftsoundstart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_cloth_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftClothStart;
                case "Play_ui_action_craft_leather_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftLeatherStart;
                case "Play_ui_action_craft_magic_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftMagicStart;
                case "Play_ui_action_craft_metal_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftMetalStart;
                case "Play_ui_action_craft_plate_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftPlateStart;
                case "Play_ui_action_craft_tool_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftToolStart;
                case "Play_ui_action_craft_wood_start":
                    return EquipmentitemUicraftsoundstart.PlayUiActionCraftWoodStart;
            }
            throw new Exception("Cannot unmarshal type EquipmentitemUicraftsoundstart");
        }

        public override void Write(Utf8JsonWriter writer, EquipmentitemUicraftsoundstart value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftClothStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_cloth_start", options);
                    return;
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftLeatherStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_leather_start", options);
                    return;
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftMagicStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_magic_start", options);
                    return;
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftMetalStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_metal_start", options);
                    return;
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftPlateStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_plate_start", options);
                    return;
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftToolStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_tool_start", options);
                    return;
                case EquipmentitemUicraftsoundstart.PlayUiActionCraftWoodStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_wood_start", options);
                    return;
            }
            throw new Exception("Cannot marshal type EquipmentitemUicraftsoundstart");
        }

        public static readonly EquipmentitemUicraftsoundstartConverter Singleton = new EquipmentitemUicraftsoundstartConverter();
    }
}

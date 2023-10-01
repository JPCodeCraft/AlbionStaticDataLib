using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumablefrominventoryitemUicraftsoundfinishConverter : JsonConverter<ConsumablefrominventoryitemUicraftsoundfinish>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumablefrominventoryitemUicraftsoundfinish);

        public override ConsumablefrominventoryitemUicraftsoundfinish Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_cloth_finish":
                    return ConsumablefrominventoryitemUicraftsoundfinish.PlayUiActionCraftClothFinish;
                case "Play_ui_action_craft_leather_finish":
                    return ConsumablefrominventoryitemUicraftsoundfinish.PlayUiActionCraftLeatherFinish;
                case "Play_ui_action_craft_potion_finish":
                    return ConsumablefrominventoryitemUicraftsoundfinish.PlayUiActionCraftPotionFinish;
            }
            throw new Exception("Cannot unmarshal type ConsumablefrominventoryitemUicraftsoundfinish");
        }

        public override void Write(Utf8JsonWriter writer, ConsumablefrominventoryitemUicraftsoundfinish value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ConsumablefrominventoryitemUicraftsoundfinish.PlayUiActionCraftClothFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_cloth_finish", options);
                    return;
                case ConsumablefrominventoryitemUicraftsoundfinish.PlayUiActionCraftLeatherFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_leather_finish", options);
                    return;
                case ConsumablefrominventoryitemUicraftsoundfinish.PlayUiActionCraftPotionFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_potion_finish", options);
                    return;
            }
            throw new Exception("Cannot marshal type ConsumablefrominventoryitemUicraftsoundfinish");
        }

        public static readonly ConsumablefrominventoryitemUicraftsoundfinishConverter Singleton = new ConsumablefrominventoryitemUicraftsoundfinishConverter();
    }
}

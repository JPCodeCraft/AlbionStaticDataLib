using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ShopConverter : JsonConverter<Shop>
    {
        public override bool CanConvert(Type t) => t == typeof(Shop);

        public override Shop Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "kill_emotes":
                    return Shop.KillEmotes;
                case "maps":
                    return Shop.Maps;
                case "other":
                    return Shop.Other;
                case "potion":
                    return Shop.Potion;
                case "skillbook":
                    return Shop.Skillbook;
                case "skillbook_fiber":
                    return Shop.SkillbookFiber;
                case "skillbook_hide":
                    return Shop.SkillbookHide;
                case "skillbook_ore":
                    return Shop.SkillbookOre;
                case "skillbook_rock":
                    return Shop.SkillbookRock;
                case "skillbook_wood":
                    return Shop.SkillbookWood;
                case "vanity":
                    return Shop.Vanity;
            }
            throw new Exception("Cannot unmarshal type Shop");
        }

        public override void Write(Utf8JsonWriter writer, Shop value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Shop.KillEmotes:
                    JsonSerializer.Serialize(writer, "kill_emotes", options);
                    return;
                case Shop.Maps:
                    JsonSerializer.Serialize(writer, "maps", options);
                    return;
                case Shop.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case Shop.Potion:
                    JsonSerializer.Serialize(writer, "potion", options);
                    return;
                case Shop.Skillbook:
                    JsonSerializer.Serialize(writer, "skillbook", options);
                    return;
                case Shop.SkillbookFiber:
                    JsonSerializer.Serialize(writer, "skillbook_fiber", options);
                    return;
                case Shop.SkillbookHide:
                    JsonSerializer.Serialize(writer, "skillbook_hide", options);
                    return;
                case Shop.SkillbookOre:
                    JsonSerializer.Serialize(writer, "skillbook_ore", options);
                    return;
                case Shop.SkillbookRock:
                    JsonSerializer.Serialize(writer, "skillbook_rock", options);
                    return;
                case Shop.SkillbookWood:
                    JsonSerializer.Serialize(writer, "skillbook_wood", options);
                    return;
                case Shop.Vanity:
                    JsonSerializer.Serialize(writer, "vanity", options);
                    return;
            }
            throw new Exception("Cannot marshal type Shop");
        }

        public static readonly ShopConverter Singleton = new ShopConverter();
    }
}

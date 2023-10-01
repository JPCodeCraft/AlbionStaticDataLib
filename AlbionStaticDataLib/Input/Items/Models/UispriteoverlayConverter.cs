using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class UispriteoverlayConverter : JsonConverter<Uispriteoverlay>
    {
        public override bool CanConvert(Type t) => t == typeof(Uispriteoverlay);

        public override Uispriteoverlay Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "ITEMOVERLAY_GUILD_VANITY":
                    return Uispriteoverlay.ItemoverlayGuildVanity;
                case "ITEMOVERLAY_KILL_EMOTE":
                    return Uispriteoverlay.ItemoverlayKillEmote;
                case "ITEMOVERLAY_NON_TRADABLE":
                    return Uispriteoverlay.ItemoverlayNonTradable;
                case "ITEMOVERLAY_NON_TRADABLE_KILL_EMOTE":
                    return Uispriteoverlay.ItemoverlayNonTradableKillEmote;
                case "ITEMOVERLAY_NON_TRADABLE_VANITY":
                    return Uispriteoverlay.ItemoverlayNonTradableVanity;
                case "ITEMOVERLAY_VANITY":
                    return Uispriteoverlay.ItemoverlayVanity;
            }
            throw new Exception("Cannot unmarshal type Uispriteoverlay");
        }

        public override void Write(Utf8JsonWriter writer, Uispriteoverlay value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Uispriteoverlay.ItemoverlayGuildVanity:
                    JsonSerializer.Serialize(writer, "ITEMOVERLAY_GUILD_VANITY", options);
                    return;
                case Uispriteoverlay.ItemoverlayKillEmote:
                    JsonSerializer.Serialize(writer, "ITEMOVERLAY_KILL_EMOTE", options);
                    return;
                case Uispriteoverlay.ItemoverlayNonTradable:
                    JsonSerializer.Serialize(writer, "ITEMOVERLAY_NON_TRADABLE", options);
                    return;
                case Uispriteoverlay.ItemoverlayNonTradableKillEmote:
                    JsonSerializer.Serialize(writer, "ITEMOVERLAY_NON_TRADABLE_KILL_EMOTE", options);
                    return;
                case Uispriteoverlay.ItemoverlayNonTradableVanity:
                    JsonSerializer.Serialize(writer, "ITEMOVERLAY_NON_TRADABLE_VANITY", options);
                    return;
                case Uispriteoverlay.ItemoverlayVanity:
                    JsonSerializer.Serialize(writer, "ITEMOVERLAY_VANITY", options);
                    return;
            }
            throw new Exception("Cannot marshal type Uispriteoverlay");
        }

        public static readonly UispriteoverlayConverter Singleton = new UispriteoverlayConverter();
    }
}

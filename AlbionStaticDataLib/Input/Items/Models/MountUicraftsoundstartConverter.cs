using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class MountUicraftsoundstartConverter : JsonConverter<MountUicraftsoundstart>
    {
        public override bool CanConvert(Type t) => t == typeof(MountUicraftsoundstart);

        public override MountUicraftsoundstart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "Play_ui_action_craft_mount_start")
            {
                return MountUicraftsoundstart.PlayUiActionCraftMountStart;
            }
            throw new Exception("Cannot unmarshal type MountUicraftsoundstart");
        }

        public override void Write(Utf8JsonWriter writer, MountUicraftsoundstart value, JsonSerializerOptions options)
        {
            if (value == MountUicraftsoundstart.PlayUiActionCraftMountStart)
            {
                JsonSerializer.Serialize(writer, "Play_ui_action_craft_mount_start", options);
                return;
            }
            throw new Exception("Cannot marshal type MountUicraftsoundstart");
        }

        public static readonly MountUicraftsoundstartConverter Singleton = new MountUicraftsoundstartConverter();
    }
}

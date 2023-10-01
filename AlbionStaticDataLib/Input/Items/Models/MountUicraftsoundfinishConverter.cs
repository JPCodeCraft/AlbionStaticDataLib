using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class MountUicraftsoundfinishConverter : JsonConverter<MountUicraftsoundfinish>
    {
        public override bool CanConvert(Type t) => t == typeof(MountUicraftsoundfinish);

        public override MountUicraftsoundfinish Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "Play_mount_mounted")
            {
                return MountUicraftsoundfinish.PlayMountMounted;
            }
            throw new Exception("Cannot unmarshal type MountUicraftsoundfinish");
        }

        public override void Write(Utf8JsonWriter writer, MountUicraftsoundfinish value, JsonSerializerOptions options)
        {
            if (value == MountUicraftsoundfinish.PlayMountMounted)
            {
                JsonSerializer.Serialize(writer, "Play_mount_mounted", options);
                return;
            }
            throw new Exception("Cannot marshal type MountUicraftsoundfinish");
        }

        public static readonly MountUicraftsoundfinishConverter Singleton = new MountUicraftsoundfinishConverter();
    }
}

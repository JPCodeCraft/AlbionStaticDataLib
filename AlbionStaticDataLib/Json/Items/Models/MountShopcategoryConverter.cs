using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    internal class MountShopcategoryConverter : JsonConverter<MountShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(MountShopcategory);

        public override MountShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "mounts")
            {
                return MountShopcategory.Mounts;
            }
            throw new Exception("Cannot unmarshal type MountShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, MountShopcategory value, JsonSerializerOptions options)
        {
            if (value == MountShopcategory.Mounts)
            {
                JsonSerializer.Serialize(writer, "mounts", options);
                return;
            }
            throw new Exception("Cannot marshal type MountShopcategory");
        }

        public static readonly MountShopcategoryConverter Singleton = new MountShopcategoryConverter();
    }
}

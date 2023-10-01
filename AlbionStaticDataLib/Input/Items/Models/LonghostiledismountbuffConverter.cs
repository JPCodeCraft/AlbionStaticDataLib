using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class LonghostiledismountbuffConverter : JsonConverter<Longhostiledismountbuff>
    {
        public override bool CanConvert(Type t) => t == typeof(Longhostiledismountbuff);

        public override Longhostiledismountbuff Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "DISMOUNTED_HOSTILE_LONG")
            {
                return Longhostiledismountbuff.DismountedHostileLong;
            }
            throw new Exception("Cannot unmarshal type Longhostiledismountbuff");
        }

        public override void Write(Utf8JsonWriter writer, Longhostiledismountbuff value, JsonSerializerOptions options)
        {
            if (value == Longhostiledismountbuff.DismountedHostileLong)
            {
                JsonSerializer.Serialize(writer, "DISMOUNTED_HOSTILE_LONG", options);
                return;
            }
            throw new Exception("Cannot marshal type Longhostiledismountbuff");
        }

        public static readonly LonghostiledismountbuffConverter Singleton = new LonghostiledismountbuffConverter();
    }
}

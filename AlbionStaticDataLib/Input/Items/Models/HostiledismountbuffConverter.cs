using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class HostiledismountbuffConverter : JsonConverter<Hostiledismountbuff>
    {
        public override bool CanConvert(Type t) => t == typeof(Hostiledismountbuff);

        public override Hostiledismountbuff Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "DISMOUNTED_HOSTILE")
            {
                return Hostiledismountbuff.DismountedHostile;
            }
            throw new Exception("Cannot unmarshal type Hostiledismountbuff");
        }

        public override void Write(Utf8JsonWriter writer, Hostiledismountbuff value, JsonSerializerOptions options)
        {
            if (value == Hostiledismountbuff.DismountedHostile)
            {
                JsonSerializer.Serialize(writer, "DISMOUNTED_HOSTILE", options);
                return;
            }
            throw new Exception("Cannot marshal type Hostiledismountbuff");
        }

        public static readonly HostiledismountbuffConverter Singleton = new HostiledismountbuffConverter();
    }
}

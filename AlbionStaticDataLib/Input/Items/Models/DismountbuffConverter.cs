using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class DismountbuffConverter : JsonConverter<Dismountbuff>
    {
        public override bool CanConvert(Type t) => t == typeof(Dismountbuff);

        public override Dismountbuff Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "DISMOUNTED")
            {
                return Dismountbuff.Dismounted;
            }
            throw new Exception("Cannot unmarshal type Dismountbuff");
        }

        public override void Write(Utf8JsonWriter writer, Dismountbuff value, JsonSerializerOptions options)
        {
            if (value == Dismountbuff.Dismounted)
            {
                JsonSerializer.Serialize(writer, "DISMOUNTED", options);
                return;
            }
            throw new Exception("Cannot marshal type Dismountbuff");
        }

        public static readonly DismountbuffConverter Singleton = new DismountbuffConverter();
    }
}

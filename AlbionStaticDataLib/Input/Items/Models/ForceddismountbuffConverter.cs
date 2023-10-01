using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ForceddismountbuffConverter : JsonConverter<Forceddismountbuff>
    {
        public override bool CanConvert(Type t) => t == typeof(Forceddismountbuff);

        public override Forceddismountbuff Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "FORCE_DISMOUNTED")
            {
                return Forceddismountbuff.ForceDismounted;
            }
            throw new Exception("Cannot unmarshal type Forceddismountbuff");
        }

        public override void Write(Utf8JsonWriter writer, Forceddismountbuff value, JsonSerializerOptions options)
        {
            if (value == Forceddismountbuff.ForceDismounted)
            {
                JsonSerializer.Serialize(writer, "FORCE_DISMOUNTED", options);
                return;
            }
            throw new Exception("Cannot marshal type Forceddismountbuff");
        }

        public static readonly ForceddismountbuffConverter Singleton = new ForceddismountbuffConverter();
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class SlottypeConverter : JsonConverter<Slottype>
    {
        public override bool CanConvert(Type t) => t == typeof(Slottype);

        public override Slottype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "mount")
            {
                return Slottype.Mount;
            }
            throw new Exception("Cannot unmarshal type Slottype");
        }

        public override void Write(Utf8JsonWriter writer, Slottype value, JsonSerializerOptions options)
        {
            if (value == Slottype.Mount)
            {
                JsonSerializer.Serialize(writer, "mount", options);
                return;
            }
            throw new Exception("Cannot marshal type Slottype");
        }

        public static readonly SlottypeConverter Singleton = new SlottypeConverter();
    }
}

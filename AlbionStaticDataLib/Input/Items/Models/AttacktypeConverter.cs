using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class AttacktypeConverter : JsonConverter<Attacktype>
    {
        public override bool CanConvert(Type t) => t == typeof(Attacktype);

        public override Attacktype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "magic":
                    return Attacktype.Magic;
                case "melee":
                    return Attacktype.Melee;
                case "ranged":
                    return Attacktype.Ranged;
                case "tools":
                    return Attacktype.Tools;
            }
            throw new Exception("Cannot unmarshal type Attacktype");
        }

        public override void Write(Utf8JsonWriter writer, Attacktype value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Attacktype.Magic:
                    JsonSerializer.Serialize(writer, "magic", options);
                    return;
                case Attacktype.Melee:
                    JsonSerializer.Serialize(writer, "melee", options);
                    return;
                case Attacktype.Ranged:
                    JsonSerializer.Serialize(writer, "ranged", options);
                    return;
                case Attacktype.Tools:
                    JsonSerializer.Serialize(writer, "tools", options);
                    return;
            }
            throw new Exception("Cannot marshal type Attacktype");
        }

        public static readonly AttacktypeConverter Singleton = new AttacktypeConverter();
    }
}

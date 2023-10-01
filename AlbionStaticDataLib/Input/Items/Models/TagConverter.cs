using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class TagConverter : JsonConverter<Tag>
    {
        public override bool CanConvert(Type t) => t == typeof(Tag);

        public override Tag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "A":
                    return Tag.A;
                case "B":
                    return Tag.B;
                case "C":
                    return Tag.C;
                case "D":
                    return Tag.D;
                case "E":
                    return Tag.E;
                case "F":
                    return Tag.F;
                case "G":
                    return Tag.G;
                case "H":
                    return Tag.H;
                case "I":
                    return Tag.I;
            }
            throw new Exception("Cannot unmarshal type Tag");
        }

        public override void Write(Utf8JsonWriter writer, Tag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Tag.A:
                    JsonSerializer.Serialize(writer, "A", options);
                    return;
                case Tag.B:
                    JsonSerializer.Serialize(writer, "B", options);
                    return;
                case Tag.C:
                    JsonSerializer.Serialize(writer, "C", options);
                    return;
                case Tag.D:
                    JsonSerializer.Serialize(writer, "D", options);
                    return;
                case Tag.E:
                    JsonSerializer.Serialize(writer, "E", options);
                    return;
                case Tag.F:
                    JsonSerializer.Serialize(writer, "F", options);
                    return;
                case Tag.G:
                    JsonSerializer.Serialize(writer, "G", options);
                    return;
                case Tag.H:
                    JsonSerializer.Serialize(writer, "H", options);
                    return;
                case Tag.I:
                    JsonSerializer.Serialize(writer, "I", options);
                    return;
            }
            throw new Exception("Cannot marshal type Tag");
        }

        public static readonly TagConverter Singleton = new TagConverter();
    }
}

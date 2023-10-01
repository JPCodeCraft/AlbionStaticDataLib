using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class LabourerfurnituretypeConverter : JsonConverter<Labourerfurnituretype>
    {
        public override bool CanConvert(Type t) => t == typeof(Labourerfurnituretype);

        public override Labourerfurnituretype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "bed":
                    return Labourerfurnituretype.Bed;
                case "table":
                    return Labourerfurnituretype.Table;
                case "trophy":
                    return Labourerfurnituretype.Trophy;
            }
            throw new Exception("Cannot unmarshal type Labourerfurnituretype");
        }

        public override void Write(Utf8JsonWriter writer, Labourerfurnituretype value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Labourerfurnituretype.Bed:
                    JsonSerializer.Serialize(writer, "bed", options);
                    return;
                case Labourerfurnituretype.Table:
                    JsonSerializer.Serialize(writer, "table", options);
                    return;
                case Labourerfurnituretype.Trophy:
                    JsonSerializer.Serialize(writer, "trophy", options);
                    return;
            }
            throw new Exception("Cannot marshal type Labourerfurnituretype");
        }

        public static readonly LabourerfurnituretypeConverter Singleton = new LabourerfurnituretypeConverter();
    }
}

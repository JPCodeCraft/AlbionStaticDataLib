using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class LabourersaffectedConverter : JsonConverter<Labourersaffected>
    {
        public override bool CanConvert(Type t) => t == typeof(Labourersaffected);

        public override Labourersaffected Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "all":
                    return Labourersaffected.All;
                case "fiber":
                    return Labourersaffected.Fiber;
                case "fishing":
                    return Labourersaffected.Fishing;
                case "hide":
                    return Labourersaffected.Hide;
                case "mercenary":
                    return Labourersaffected.Mercenary;
                case "ore":
                    return Labourersaffected.Ore;
                case "stone":
                    return Labourersaffected.Stone;
                case "wood":
                    return Labourersaffected.Wood;
            }
            throw new Exception("Cannot unmarshal type Labourersaffected");
        }

        public override void Write(Utf8JsonWriter writer, Labourersaffected value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Labourersaffected.All:
                    JsonSerializer.Serialize(writer, "all", options);
                    return;
                case Labourersaffected.Fiber:
                    JsonSerializer.Serialize(writer, "fiber", options);
                    return;
                case Labourersaffected.Fishing:
                    JsonSerializer.Serialize(writer, "fishing", options);
                    return;
                case Labourersaffected.Hide:
                    JsonSerializer.Serialize(writer, "hide", options);
                    return;
                case Labourersaffected.Mercenary:
                    JsonSerializer.Serialize(writer, "mercenary", options);
                    return;
                case Labourersaffected.Ore:
                    JsonSerializer.Serialize(writer, "ore", options);
                    return;
                case Labourersaffected.Stone:
                    JsonSerializer.Serialize(writer, "stone", options);
                    return;
                case Labourersaffected.Wood:
                    JsonSerializer.Serialize(writer, "wood", options);
                    return;
            }
            throw new Exception("Cannot marshal type Labourersaffected");
        }

        public static readonly LabourersaffectedConverter Singleton = new LabourersaffectedConverter();
    }
}

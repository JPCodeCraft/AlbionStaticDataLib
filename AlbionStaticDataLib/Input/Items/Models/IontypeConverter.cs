using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class IontypeConverter : JsonConverter<Iontype>
    {
        public override bool CanConvert(Type t) => t == typeof(Iontype);

        public override Iontype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "armor":
                    return Iontype.Armor;
                case "avalonshield":
                    return Iontype.Avalonshield;
                case "bag":
                    return Iontype.Bag;
                case "book":
                    return Iontype.Book;
                case "cane":
                    return Iontype.Cane;
                case "cape":
                    return Iontype.Cape;
                case "censer":
                    return Iontype.Censer;
                case "demonskull":
                    return Iontype.Demonskull;
                case "head":
                    return Iontype.Head;
                case "horn":
                    return Iontype.Horn;
                case "lamp":
                    return Iontype.Lamp;
                case "orb":
                    return Iontype.Orb;
                case "shield":
                    return Iontype.Shield;
                case "shoes":
                    return Iontype.Shoes;
                case "skullshield":
                    return Iontype.Skullshield;
                case "spikedshield":
                    return Iontype.Spikedshield;
                case "talisman":
                    return Iontype.Talisman;
                case "torch":
                    return Iontype.Torch;
                case "totem":
                    return Iontype.Totem;
                case "towershield":
                    return Iontype.Towershield;
            }
            throw new Exception("Cannot unmarshal type Iontype");
        }

        public override void Write(Utf8JsonWriter writer, Iontype value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Iontype.Armor:
                    JsonSerializer.Serialize(writer, "armor", options);
                    return;
                case Iontype.Avalonshield:
                    JsonSerializer.Serialize(writer, "avalonshield", options);
                    return;
                case Iontype.Bag:
                    JsonSerializer.Serialize(writer, "bag", options);
                    return;
                case Iontype.Book:
                    JsonSerializer.Serialize(writer, "book", options);
                    return;
                case Iontype.Cane:
                    JsonSerializer.Serialize(writer, "cane", options);
                    return;
                case Iontype.Cape:
                    JsonSerializer.Serialize(writer, "cape", options);
                    return;
                case Iontype.Censer:
                    JsonSerializer.Serialize(writer, "censer", options);
                    return;
                case Iontype.Demonskull:
                    JsonSerializer.Serialize(writer, "demonskull", options);
                    return;
                case Iontype.Head:
                    JsonSerializer.Serialize(writer, "head", options);
                    return;
                case Iontype.Horn:
                    JsonSerializer.Serialize(writer, "horn", options);
                    return;
                case Iontype.Lamp:
                    JsonSerializer.Serialize(writer, "lamp", options);
                    return;
                case Iontype.Orb:
                    JsonSerializer.Serialize(writer, "orb", options);
                    return;
                case Iontype.Shield:
                    JsonSerializer.Serialize(writer, "shield", options);
                    return;
                case Iontype.Shoes:
                    JsonSerializer.Serialize(writer, "shoes", options);
                    return;
                case Iontype.Skullshield:
                    JsonSerializer.Serialize(writer, "skullshield", options);
                    return;
                case Iontype.Spikedshield:
                    JsonSerializer.Serialize(writer, "spikedshield", options);
                    return;
                case Iontype.Talisman:
                    JsonSerializer.Serialize(writer, "talisman", options);
                    return;
                case Iontype.Torch:
                    JsonSerializer.Serialize(writer, "torch", options);
                    return;
                case Iontype.Totem:
                    JsonSerializer.Serialize(writer, "totem", options);
                    return;
                case Iontype.Towershield:
                    JsonSerializer.Serialize(writer, "towershield", options);
                    return;
            }
            throw new Exception("Cannot marshal type Iontype");
        }

        public static readonly IontypeConverter Singleton = new IontypeConverter();
    }
}

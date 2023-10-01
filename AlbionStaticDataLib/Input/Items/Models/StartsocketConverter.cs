using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class StartsocketConverter : JsonConverter<Startsocket>
    {
        public override bool CanConvert(Type t) => t == typeof(Startsocket);

        public override Startsocket Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "mainhandprojectile":
                    return Startsocket.Mainhandprojectile;
                case "mainhandprojectilemuzzle":
                    return Startsocket.Mainhandprojectilemuzzle;
                case "offhandprojectile":
                    return Startsocket.Offhandprojectile;
            }
            throw new Exception("Cannot unmarshal type Startsocket");
        }

        public override void Write(Utf8JsonWriter writer, Startsocket value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Startsocket.Mainhandprojectile:
                    JsonSerializer.Serialize(writer, "mainhandprojectile", options);
                    return;
                case Startsocket.Mainhandprojectilemuzzle:
                    JsonSerializer.Serialize(writer, "mainhandprojectilemuzzle", options);
                    return;
                case Startsocket.Offhandprojectile:
                    JsonSerializer.Serialize(writer, "offhandprojectile", options);
                    return;
            }
            throw new Exception("Cannot marshal type Startsocket");
        }

        public static readonly StartsocketConverter Singleton = new StartsocketConverter();
    }
}

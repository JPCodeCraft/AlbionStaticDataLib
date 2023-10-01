using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class SpellslotConverter : JsonConverter<Spellslot>
    {
        public override bool CanConvert(Type t) => t == typeof(Spellslot);

        public override Spellslot Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "armor":
                    return Spellslot.Armor;
                case "head":
                    return Spellslot.Head;
                case "mainhand1":
                    return Spellslot.Mainhand1;
                case "mainhand2":
                    return Spellslot.Mainhand2;
                case "offhandormainhand3":
                    return Spellslot.Offhandormainhand3;
                case "shoes":
                    return Spellslot.Shoes;
            }
            throw new Exception("Cannot unmarshal type Spellslot");
        }

        public override void Write(Utf8JsonWriter writer, Spellslot value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Spellslot.Armor:
                    JsonSerializer.Serialize(writer, "armor", options);
                    return;
                case Spellslot.Head:
                    JsonSerializer.Serialize(writer, "head", options);
                    return;
                case Spellslot.Mainhand1:
                    JsonSerializer.Serialize(writer, "mainhand1", options);
                    return;
                case Spellslot.Mainhand2:
                    JsonSerializer.Serialize(writer, "mainhand2", options);
                    return;
                case Spellslot.Offhandormainhand3:
                    JsonSerializer.Serialize(writer, "offhandormainhand3", options);
                    return;
                case Spellslot.Shoes:
                    JsonSerializer.Serialize(writer, "shoes", options);
                    return;
            }
            throw new Exception("Cannot marshal type Spellslot");
        }

        public static readonly SpellslotConverter Singleton = new SpellslotConverter();
    }
}

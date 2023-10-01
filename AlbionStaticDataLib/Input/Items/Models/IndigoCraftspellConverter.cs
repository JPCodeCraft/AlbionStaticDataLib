using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class IndigoCraftspellConverter : JsonConverter<IndigoCraftspell>
    {
        public override bool CanConvert(Type t) => t == typeof(IndigoCraftspell);

        public override IndigoCraftspell Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<PurpleCraftspell>(ref reader, options);
                    return new IndigoCraftspell { PurpleCraftspell = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<TentacledCraftspell>>(ref reader, options);
                    return new IndigoCraftspell { TentacledCraftspellArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type IndigoCraftspell");
        }

        public override void Write(Utf8JsonWriter writer, IndigoCraftspell value, JsonSerializerOptions options)
        {
            if (value.TentacledCraftspellArray != null)
            {
                JsonSerializer.Serialize(writer, value.TentacledCraftspellArray, options);
                return;
            }
            if (value.PurpleCraftspell != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleCraftspell, options);
                return;
            }
            throw new Exception("Cannot marshal type IndigoCraftspell");
        }

        public static readonly IndigoCraftspellConverter Singleton = new IndigoCraftspellConverter();
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class StickyCraftspellConverter : JsonConverter<StickyCraftspell>
    {
        public override bool CanConvert(Type t) => t == typeof(StickyCraftspell);

        public override StickyCraftspell Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<FluffyCraftspell>(ref reader, options);
                    return new StickyCraftspell { FluffyCraftspell = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<PurpleCraftspell>>(ref reader, options);
                    return new StickyCraftspell { PurpleCraftspellArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StickyCraftspell");
        }

        public override void Write(Utf8JsonWriter writer, StickyCraftspell value, JsonSerializerOptions options)
        {
            if (value.PurpleCraftspellArray != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleCraftspellArray, options);
                return;
            }
            if (value.FluffyCraftspell != null)
            {
                JsonSerializer.Serialize(writer, value.FluffyCraftspell, options);
                return;
            }
            throw new Exception("Cannot marshal type StickyCraftspell");
        }

        public static readonly StickyCraftspellConverter Singleton = new StickyCraftspellConverter();
    }
}

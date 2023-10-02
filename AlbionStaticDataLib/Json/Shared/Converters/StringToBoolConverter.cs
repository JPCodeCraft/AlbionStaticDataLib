namespace AlbionStaticDataLib.Json.Shared.Converters

{
    internal class StringToBoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            bool b;
            if (bool.TryParse(value, out b))
            {
                return b;
            }
            throw new JsonException($"Failed to parse '{value}' as bool at {reader.TokenType} {reader.ValueSpan.ToString()}.");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }
    }
}

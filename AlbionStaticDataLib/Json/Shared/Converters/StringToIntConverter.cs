namespace AlbionStaticDataLib.Json.Shared.Converters

{
    internal class StringToIntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            int i;
            if (int.TryParse(value, out i))
            {
                return i;
            }
            throw new JsonException($"Failed to parse '{value}' as int at {reader.TokenType} {reader.ValueSpan.ToString()}.");
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }
    }
}

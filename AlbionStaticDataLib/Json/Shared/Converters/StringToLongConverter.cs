namespace AlbionStaticDataLib.Json.Shared.Converters

{
    internal class StringToLongConverter : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            long l;
            if (long.TryParse(value, out l))
            {
                return l;
            }
            throw new JsonException($"Failed to parse '{value}' as long at {reader.TokenType} {reader.ValueSpan.ToString()}.");
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }
    }
}

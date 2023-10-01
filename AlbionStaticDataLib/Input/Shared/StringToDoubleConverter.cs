namespace AlbionStaticDataLib.Input.Shared

{
    internal class StringToDoubleConverter : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            double d;
            if (double.TryParse(value, out d))
            {
                return d;
            }
            throw new JsonException($"Failed to parse '{value}' as double at {reader.TokenType} {reader.ValueSpan.ToString()}.");
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }
    }
}

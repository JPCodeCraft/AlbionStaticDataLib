using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ProjectileUnionConverter : JsonConverter<ProjectileUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(ProjectileUnion);

        public override ProjectileUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<ProjectileElement>(ref reader, options);
                    return new ProjectileUnion { ProjectileElement = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<ProjectileElement>>(ref reader, options);
                    return new ProjectileUnion { ProjectileElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ProjectileUnion");
        }

        public override void Write(Utf8JsonWriter writer, ProjectileUnion value, JsonSerializerOptions options)
        {
            if (value.ProjectileElementArray != null)
            {
                JsonSerializer.Serialize(writer, value.ProjectileElementArray, options);
                return;
            }
            if (value.ProjectileElement != null)
            {
                JsonSerializer.Serialize(writer, value.ProjectileElement, options);
                return;
            }
            throw new Exception("Cannot marshal type ProjectileUnion");
        }

        public static readonly ProjectileUnionConverter Singleton = new ProjectileUnionConverter();
    }
}

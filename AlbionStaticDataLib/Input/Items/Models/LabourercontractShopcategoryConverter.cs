using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class LabourercontractShopcategoryConverter : JsonConverter<LabourercontractShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(LabourercontractShopcategory);

        public override LabourercontractShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "labourers")
            {
                return LabourercontractShopcategory.Labourers;
            }
            throw new Exception("Cannot unmarshal type LabourercontractShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, LabourercontractShopcategory value, JsonSerializerOptions options)
        {
            if (value == LabourercontractShopcategory.Labourers)
            {
                JsonSerializer.Serialize(writer, "labourers", options);
                return;
            }
            throw new Exception("Cannot marshal type LabourercontractShopcategory");
        }

        public static readonly LabourercontractShopcategoryConverter Singleton = new LabourercontractShopcategoryConverter();
    }
}

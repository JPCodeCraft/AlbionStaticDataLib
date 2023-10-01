using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FoodcategoryConverter : JsonConverter<Foodcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(Foodcategory);

        public override Foodcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "chocolate":
                    return Foodcategory.Chocolate;
                case "meat":
                    return Foodcategory.Meat;
                case "plants":
                    return Foodcategory.Plants;
            }
            throw new Exception("Cannot unmarshal type Foodcategory");
        }

        public override void Write(Utf8JsonWriter writer, Foodcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Foodcategory.Chocolate:
                    JsonSerializer.Serialize(writer, "chocolate", options);
                    return;
                case Foodcategory.Meat:
                    JsonSerializer.Serialize(writer, "meat", options);
                    return;
                case Foodcategory.Plants:
                    JsonSerializer.Serialize(writer, "plants", options);
                    return;
            }
            throw new Exception("Cannot marshal type Foodcategory");
        }

        public static readonly FoodcategoryConverter Singleton = new FoodcategoryConverter();
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    internal class CrystalleagueitemShopcategoryConverter : JsonConverter<CrystalleagueitemShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(CrystalleagueitemShopcategory);

        public override CrystalleagueitemShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "artefacts":
                    return CrystalleagueitemShopcategory.Artefacts;
                case "cityresources":
                    return CrystalleagueitemShopcategory.Cityresources;
                case "luxurygoods":
                    return CrystalleagueitemShopcategory.Luxurygoods;
                case "materials":
                    return CrystalleagueitemShopcategory.Materials;
                case "other":
                    return CrystalleagueitemShopcategory.Other;
                case "products":
                    return CrystalleagueitemShopcategory.Products;
                case "resources":
                    return CrystalleagueitemShopcategory.Resources;
                case "token":
                    return CrystalleagueitemShopcategory.Token;
            }
            throw new Exception("Cannot unmarshal type CrystalleagueitemShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, CrystalleagueitemShopcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case CrystalleagueitemShopcategory.Artefacts:
                    JsonSerializer.Serialize(writer, "artefacts", options);
                    return;
                case CrystalleagueitemShopcategory.Cityresources:
                    JsonSerializer.Serialize(writer, "cityresources", options);
                    return;
                case CrystalleagueitemShopcategory.Luxurygoods:
                    JsonSerializer.Serialize(writer, "luxurygoods", options);
                    return;
                case CrystalleagueitemShopcategory.Materials:
                    JsonSerializer.Serialize(writer, "materials", options);
                    return;
                case CrystalleagueitemShopcategory.Other:
                    JsonSerializer.Serialize(writer, "other", options);
                    return;
                case CrystalleagueitemShopcategory.Products:
                    JsonSerializer.Serialize(writer, "products", options);
                    return;
                case CrystalleagueitemShopcategory.Resources:
                    JsonSerializer.Serialize(writer, "resources", options);
                    return;
                case CrystalleagueitemShopcategory.Token:
                    JsonSerializer.Serialize(writer, "token", options);
                    return;
            }
            throw new Exception("Cannot marshal type CrystalleagueitemShopcategory");
        }

        public static readonly CrystalleagueitemShopcategoryConverter Singleton = new CrystalleagueitemShopcategoryConverter();
    }
}

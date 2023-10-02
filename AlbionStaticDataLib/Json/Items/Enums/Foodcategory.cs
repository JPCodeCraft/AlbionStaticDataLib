using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Foodcategory>))]
    public enum Foodcategory { Chocolate, Meat, Plants };
}

using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Foodcategory>))]
    public enum Foodcategory { Chocolate, Meat, Plants };
}

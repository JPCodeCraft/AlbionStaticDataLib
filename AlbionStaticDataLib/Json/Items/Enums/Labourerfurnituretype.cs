namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Labourerfurnituretype>))]
    public enum Labourerfurnituretype { Bed, Table, Trophy };
}

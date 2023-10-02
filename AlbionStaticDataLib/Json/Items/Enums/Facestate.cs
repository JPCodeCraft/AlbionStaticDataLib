namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Facestate>))]
    public enum Facestate { Empty, Face, Half, Hood };
}

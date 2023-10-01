namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Labourersaffected>))]
    public enum Labourersaffected { All, Fiber, Fishing, Hide, Mercenary, Ore, Stone, Wood };
}

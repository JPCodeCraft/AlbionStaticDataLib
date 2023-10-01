namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Container
    {
        [JsonPropertyName("@capacity")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Capacity { get; set; }

        [JsonPropertyName("@weightlimit")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weightlimit { get; set; }
    }
}

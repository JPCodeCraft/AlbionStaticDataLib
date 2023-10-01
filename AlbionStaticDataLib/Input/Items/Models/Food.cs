using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Food
    {
        [JsonPropertyName("@nutritionmax")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Nutritionmax { get; set; }

        [JsonPropertyName("@secondspernutrition")]
        public string Secondspernutrition { get; set; }

        [JsonPropertyName("acceptedfood")]
        public Acceptedfood Acceptedfood { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@lossbeforehungry")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Lossbeforehungry { get; set; }
    }
}

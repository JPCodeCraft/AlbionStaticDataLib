using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Food
    {
        [JsonPropertyName("@nutritionmax")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Nutritionmax { get; set; }

        [JsonPropertyName("@secondspernutrition")]
        public string Secondspernutrition { get; set; }

        [JsonPropertyName("acceptedfood")]
        public Acceptedfood Acceptedfood { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@lossbeforehungry")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Lossbeforehungry { get; set; }
    }
}

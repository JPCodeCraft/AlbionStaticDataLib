using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class FluffyCraftingrequirements
    {
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Amountcrafted { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("craftresource")]
        public List<CraftingrequirementCraftresourceClass> Craftresource { get; set; }
    }
}

using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class IndecentCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Craftingfocus { get; set; }

        [JsonPropertyName("craftresource")]
        public FluffyCraftresource Craftresource { get; set; }
    }
}

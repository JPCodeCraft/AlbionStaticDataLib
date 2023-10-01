using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Resources.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class TierElement
    {
        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Tier { get; set; }

        [JsonPropertyName("@item")]
        public string Item { get; set; }

        [JsonPropertyName("@maxchargesperharvest")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxchargesperharvest { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawntimeseconds")]
        public string Respawntimeseconds { get; set; }

        [JsonPropertyName("@harvesttimeseconds")]
        public string Harvesttimeseconds { get; set; }

        [JsonPropertyName("@requirestool")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Requirestool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@notooltimefactor")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Notooltimefactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@startcharges")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Startcharges { get; set; }

        [JsonPropertyName("Charge")]
        public List<Charge> Charge { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RareState")]
        public List<RareState> RareState { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tile")]
        public string Tile { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@decaytimeseconds")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Decaytimeseconds { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@decaytimewhenexhaustedseconds")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Decaytimewhenexhaustedseconds { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tilepremium")]
        public Tilepremium? Tilepremium { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@isscaled")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Isscaled { get; set; }
    }
}
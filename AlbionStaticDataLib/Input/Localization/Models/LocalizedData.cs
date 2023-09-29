using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Localization.Models
{
    public class LocalizedData
    {
        [JsonPropertyName("EN-US")]
        public string EnUs { get; set; }

        [JsonPropertyName("DE-DE")]
        public string DeDe { get; set; }

        [JsonPropertyName("FR-FR")]
        public string FrFr { get; set; }

        [JsonPropertyName("RU-RU")]
        public string RuRu { get; set; }

        [JsonPropertyName("PL-PL")]
        public string PlPl { get; set; }

        [JsonPropertyName("ES-ES")]
        public string EsEs { get; set; }

        [JsonPropertyName("PT-BR")]
        public string PtBr { get; set; }

        [JsonPropertyName("IT-IT")]
        public string ItIt { get; set; }

        [JsonPropertyName("ZH-CN")]
        public string ZhCn { get; set; }

        [JsonPropertyName("KO-KR")]
        public string KoKr { get; set; }

        [JsonPropertyName("JA-JP")]
        public string JaJp { get; set; }

        [JsonPropertyName("ZH-TW")]
        public string ZhTw { get; set; }

        [JsonPropertyName("ID-ID")]
        public string IdId { get; set; }
    }
}
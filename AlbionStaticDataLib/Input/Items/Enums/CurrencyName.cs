using AlbionStaticDataLib.Input.Items.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(CurrencynameConverter))]
    public enum CurrencyName
    {
        FactionCaerleon, FactionForest, FactionHighland, FactionMountain,
        FactionSteppe, FactionSwamp, Favor
    };
}

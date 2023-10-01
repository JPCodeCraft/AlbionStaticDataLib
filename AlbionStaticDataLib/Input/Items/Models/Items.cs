using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Items
    {
        [JsonPropertyName("@xmlns:xsi")]
        public Uri XmlnsXsi { get; set; }

        [JsonPropertyName("@xsi:noNamespaceSchemaLocation")]
        public string XsiNoNamespaceSchemaLocation { get; set; }

        [JsonPropertyName("shopcategories")]
        public Shopcategories Shopcategories { get; set; }

        [JsonPropertyName("hideoutitem")]
        public Hideoutitem Hideoutitem { get; set; }

        [JsonPropertyName("farmableitem")]
        public List<Farmableitem> Farmableitem { get; set; }

        [JsonPropertyName("simpleitem")]
        public List<Simpleitem> Simpleitem { get; set; }

        [JsonPropertyName("consumableitem")]
        public List<Consumableitem> Consumableitem { get; set; }

        [JsonPropertyName("consumablefrominventoryitem")]
        public List<Consumablefrominventoryitem> Consumablefrominventoryitem { get; set; }

        [JsonPropertyName("equipmentitem")]
        public List<Equipmentitem> Equipmentitem { get; set; }

        [JsonPropertyName("weapon")]
        public List<Weapon> Weapon { get; set; }

        [JsonPropertyName("mount")]
        public List<Mount> Mount { get; set; }

        [JsonPropertyName("furnitureitem")]
        public List<Furnitureitem> Furnitureitem { get; set; }

        [JsonPropertyName("mountskin")]
        public List<Mountskin> Mountskin { get; set; }

        [JsonPropertyName("journalitem")]
        public List<Journalitem> Journalitem { get; set; }

        [JsonPropertyName("labourercontract")]
        public List<Labourercontract> Labourercontract { get; set; }

        [JsonPropertyName("crystalleagueitem")]
        public List<Crystalleagueitem> Crystalleagueitem { get; set; }

        [JsonPropertyName("killtrophy")]
        public Killtrophy Killtrophy { get; set; }
    }
}

using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Equipmentitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonPropertyName("@maxqualitylevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxqualitylevel { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@slottype")]
        public Slottype Slottype { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itempowerprogressiontype")]
        public Itempowerprogressiontype? Itempowerprogressiontype { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uicraftsoundstart")]
        public string? Uicraftsoundstart { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uicraftsoundfinish")]
        public string? Uicraftsoundfinish { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@skincount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Skincount { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tier { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }

        [JsonPropertyName("@activespellslots")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Activespellslots { get; set; }

        [JsonPropertyName("@passivespellslots")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Passivespellslots { get; set; }

        [JsonPropertyName("@physicalarmor")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Physicalarmor { get; set; }

        [JsonPropertyName("@magicresistance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Magicresistance { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("@durabilityloss_attack")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double DurabilitylossAttack { get; set; }

        [JsonPropertyName("@durabilityloss_spelluse")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double DurabilitylossSpelluse { get; set; }

        [JsonPropertyName("@durabilityloss_receivedattack")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double DurabilitylossReceivedattack { get; set; }

        [JsonPropertyName("@durabilityloss_receivedspell")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double DurabilitylossReceivedspell { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@offhandanimationtype")]
        public string? Offhandanimationtype { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@unlockedtoequip")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Unlockedtoequip { get; set; }

        [JsonPropertyName("@hitpointsmax")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Hitpointsmax { get; set; }

        [JsonPropertyName("@hitpointsregenerationbonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Hitpointsregenerationbonus { get; set; }

        [JsonPropertyName("@energymax")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Energymax { get; set; }

        [JsonPropertyName("@energyregenerationbonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Energyregenerationbonus { get; set; }

        [JsonPropertyName("@crowdcontrolresistance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Crowdcontrolresistance { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@physicalattackdamagebonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Physicalattackdamagebonus { get; set; }

        [JsonPropertyName("@magicattackdamagebonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Magicattackdamagebonus { get; set; }

        [JsonPropertyName("@physicalspelldamagebonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Physicalspelldamagebonus { get; set; }

        [JsonPropertyName("@magicspelldamagebonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Magicspelldamagebonus { get; set; }

        [JsonPropertyName("@healbonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Healbonus { get; set; }

        [JsonPropertyName("@bonusccdurationvsplayers")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Bonusccdurationvsplayers { get; set; }

        [JsonPropertyName("@bonusccdurationvsmobs")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Bonusccdurationvsmobs { get; set; }

        [JsonPropertyName("@threatbonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Threatbonus { get; set; }

        [JsonPropertyName("@magiccooldownreduction")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Magiccooldownreduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusdefensevsplayers")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Bonusdefensevsplayers { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusdefensevsmobs")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Bonusdefensevsmobs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magiccasttimereduction")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Magiccasttimereduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackspeedbonus")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Attackspeedbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@movespeedbonus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Movespeedbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@healmodifier")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Healmodifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canbeovercharged")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Canbeovercharged { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Showinmarketplace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@energycostreduction")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Energycostreduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@masterymodifier")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Masterymodifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingcategory")]
        public Craftingcategory? Craftingcategory { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@combatspecachievement")]
        public string Combatspecachievement { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SocketPreset")]
        public AudioInfo SocketPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enchantments")]
        public Enchantments Enchantments { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@destinycraftfamefactor")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Destinycraftfamefactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetVfxPreset")]
        public AudioInfo AssetVfxPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@famevalue")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Famevalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingspelllist")]
        public Craftingspelllist Craftingspelllist { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public string? Descriptionlocatag { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tradable")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Tradable { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@movespeed")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Movespeed { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@maxload")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Maxload { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@facestate")]
        public Facestate? Facestate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hidefromplayeroncontext")]
        public string? Hidefromplayeroncontext { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@scalemodifier")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Scalemodifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@requiredaccesslevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Requiredaccesslevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uispriteoverlay1")]
        public string? Uispriteoverlay1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@beardstate")]
        public Beardstate? Beardstate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@mesh")]
        public string Mesh { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@omitmesh")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Omitmesh { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@mainhandanimationtype")]
        public string Mainhandanimationtype { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@skincolormodifier")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Skincolormodifier { get; set; }
    }
}

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
        [JsonConverter(typeof(StringToLongConverter))]
        public long Tier { get; set; }

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
        public string DurabilitylossAttack { get; set; }

        [JsonPropertyName("@durabilityloss_spelluse")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossSpelluse { get; set; }

        [JsonPropertyName("@durabilityloss_receivedattack")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossReceivedattack { get; set; }

        [JsonPropertyName("@durabilityloss_receivedspell")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossReceivedspell { get; set; }

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
        public string Hitpointsregenerationbonus { get; set; }

        [JsonPropertyName("@energymax")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Energymax { get; set; }

        [JsonPropertyName("@energyregenerationbonus")]
        public string Energyregenerationbonus { get; set; }

        [JsonPropertyName("@crowdcontrolresistance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Crowdcontrolresistance { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@physicalattackdamagebonus")]
        public string Physicalattackdamagebonus { get; set; }

        [JsonPropertyName("@magicattackdamagebonus")]
        public string Magicattackdamagebonus { get; set; }

        [JsonPropertyName("@physicalspelldamagebonus")]
        public string Physicalspelldamagebonus { get; set; }

        [JsonPropertyName("@magicspelldamagebonus")]
        public string Magicspelldamagebonus { get; set; }

        [JsonPropertyName("@healbonus")]
        public string Healbonus { get; set; }

        [JsonPropertyName("@bonusccdurationvsplayers")]
        public string Bonusccdurationvsplayers { get; set; }

        [JsonPropertyName("@bonusccdurationvsmobs")]
        public string Bonusccdurationvsmobs { get; set; }

        [JsonPropertyName("@threatbonus")]
        public string Threatbonus { get; set; }

        [JsonPropertyName("@magiccooldownreduction")]
        public string Magiccooldownreduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusdefensevsplayers")]
        public string Bonusdefensevsplayers { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusdefensevsmobs")]
        public string Bonusdefensevsmobs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magiccasttimereduction")]
        public string Magiccasttimereduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackspeedbonus")]
        public string Attackspeedbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@movespeedbonus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Movespeedbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@healmodifier")]
        public string Healmodifier { get; set; }

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
        public string Energycostreduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@masterymodifier")]
        public string Masterymodifier { get; set; }

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
        [JsonConverter(typeof(SingleOrArrayConverter<Enchantment>))]
        public List<Enchantment>? Enchantments { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@destinycraftfamefactor")]
        public string Destinycraftfamefactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetVfxPreset")]
        public AudioInfo AssetVfxPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@famevalue")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Famevalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingspelllist")]
        public EquipmentitemCraftingspelllist Craftingspelllist { get; set; }

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
        public string Scalemodifier { get; set; }

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

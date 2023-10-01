using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Weapon
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@mesh")]
        public string Mesh { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonPropertyName("@maxqualitylevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Maxqualitylevel { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@slottype")]
        public ItempowerprogressiontypeEnum Slottype { get; set; }

        [JsonPropertyName("@shopcategory")]
        public Attacktype Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@attacktype")]
        public Attacktype Attacktype { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackdamage")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Attackdamage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackspeed")]
        public string Attackspeed { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackrange")]
        public string Attackrange { get; set; }

        [JsonPropertyName("@twohanded")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Twohanded { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Tier { get; set; }

        [JsonPropertyName("@weight")]
        public string Weight { get; set; }

        [JsonPropertyName("@activespellslots")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Activespellslots { get; set; }

        [JsonPropertyName("@passivespellslots")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Passivespellslots { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("@durabilityloss_attack")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossAttack { get; set; }

        [JsonPropertyName("@durabilityloss_spelluse")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossSpelluse { get; set; }

        [JsonPropertyName("@durabilityloss_receivedattack")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossReceivedattack { get; set; }

        [JsonPropertyName("@durabilityloss_receivedspell")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossReceivedspell { get; set; }

        [JsonPropertyName("@mainhandanimationtype")]
        public string Mainhandanimationtype { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@unlockedtoequip")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtoequip { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Itempower { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@unequipincombat")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Unequipincombat { get; set; }

        [JsonPropertyName("@uicraftsoundstart")]
        public EquipmentitemUicraftsoundstart Uicraftsoundstart { get; set; }

        [JsonPropertyName("@uicraftsoundfinish")]
        public EquipmentitemUicraftsoundfinish Uicraftsoundfinish { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canbeovercharged")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Canbeovercharged { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("canharvest")]
        public Canharvest Canharvest { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingrequirements")]
        public WeaponCraftingrequirements? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SocketPreset")]
        public AudioInfo SocketPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingcategory")]
        public ShopsubcategoryName? Craftingcategory { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public WeaponDescriptionlocatag? Descriptionlocatag { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingspelllist")]
        public WeaponCraftingspelllist Craftingspelllist { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackbuildingdamage")]
        public string Attackbuildingdamage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fishing")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Fishing { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fishingspeed")]
        public string Fishingspeed { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@physicalspelldamagebonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Physicalspelldamagebonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magicspelldamagebonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Magicspelldamagebonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fxbonename")]
        public Fxbonename? Fxbonename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fxboneoffset")]
        public Fxboneoffset? Fxboneoffset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hitpointsmax")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Hitpointsmax { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hitpointsregenerationbonus")]
        public string Hitpointsregenerationbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itempowerprogressiontype")]
        public ItempowerprogressiontypeEnum? Itempowerprogressiontype { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@focusfireprotectionpenetration")]
        public string Focusfireprotectionpenetration { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@healmodifier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Healmodifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@masterymodifier")]
        public string Masterymodifier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@physicalattackdamagebonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Physicalattackdamagebonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magicattackdamagebonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Magicattackdamagebonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attackvariations")]
        public Attackvariations Attackvariations { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("projectile")]
        public ProjectileUnion? Projectile { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@combatspecachievement")]
        public string Combatspecachievement { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enchantments")]
        public EquipmentitemEnchantments Enchantments { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@destinycraftfamefactor")]
        public string Destinycraftfamefactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Showinmarketplace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetVfxPreset")]
        public AudioInfo AssetVfxPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@triggershealingsickness")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Triggershealingsickness { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hidefromplayeroncontext")]
        public Hidefromplayeroncontext? Hidefromplayeroncontext { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@requiredaccesslevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Requiredaccesslevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackdamagetimefactor")]
        public string Attackdamagetimefactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@mainhandanimationtype_attack")]
        public MainhandanimationtypeAttack? MainhandanimationtypeAttack { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attackvfx")]
        public WeaponAttackvfx Attackvfx { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tradable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Tradable { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@skincount")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Skincount { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@physicalarmor")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Physicalarmor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magicresistance")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Magicresistance { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@energymax")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Energymax { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@energyregenerationbonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Energyregenerationbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@crowdcontrolresistance")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Crowdcontrolresistance { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@healbonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Healbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusccdurationvsplayers")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Bonusccdurationvsplayers { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusccdurationvsmobs")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Bonusccdurationvsmobs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@threatbonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Threatbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magiccooldownreduction")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Magiccooldownreduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusdefensevsplayers")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Bonusdefensevsplayers { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@bonusdefensevsmobs")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Bonusdefensevsmobs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@magiccasttimereduction")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Magiccasttimereduction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@attackspeedbonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Attackspeedbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@movespeedbonus")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Movespeedbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@namelocatag")]
        public string Namelocatag { get; set; }
    }
}

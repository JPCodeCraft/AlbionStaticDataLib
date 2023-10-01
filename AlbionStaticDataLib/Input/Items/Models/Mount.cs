using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Mount
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@mountcategory")]
        public string Mountcategory { get; set; }

        [JsonPropertyName("@maxqualitylevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxqualitylevel { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@slottype")]
        public Slottype Slottype { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@mountedbuff")]
        public string Mountedbuff { get; set; }

        [JsonPropertyName("@halfmountedbuff")]
        public string Halfmountedbuff { get; set; }

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

        [JsonPropertyName("@durability")]
        public string Durability { get; set; }

        [JsonPropertyName("@durabilityloss_attack")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossAttack { get; set; }

        [JsonPropertyName("@durabilityloss_spelluse")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossSpelluse { get; set; }

        [JsonPropertyName("@durabilityloss_receivedattack")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossReceivedattack { get; set; }

        [JsonPropertyName("@durabilityloss_receivedspell")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossReceivedspell { get; set; }

        [JsonPropertyName("@durabilityloss_receivedattack_mounted")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossReceivedattackMounted { get; set; }

        [JsonPropertyName("@durabilityloss_receivedspell_mounted")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossReceivedspellMounted { get; set; }

        [JsonPropertyName("@durabilityloss_mounting")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long DurabilitylossMounting { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@unlockedtoequip")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtoequip { get; set; }

        [JsonPropertyName("@mounttime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Mounttime { get; set; }

        [JsonPropertyName("@dismounttime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Dismounttime { get; set; }

        [JsonPropertyName("@mounthitpointsmax")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Mounthitpointsmax { get; set; }

        [JsonPropertyName("@mounthitpointsregeneration")]
        public string Mounthitpointsregeneration { get; set; }

        [JsonPropertyName("@prefabname")]
        public string Prefabname { get; set; }

        [JsonPropertyName("@prefabscaling")]
        public string Prefabscaling { get; set; }

        [JsonPropertyName("@despawneffect")]
        public string Despawneffect { get; set; }

        [JsonPropertyName("@despawneffectscaling")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Despawneffectscaling { get; set; }

        [JsonPropertyName("@remountdistance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Remountdistance { get; set; }

        [JsonPropertyName("@halfmountrange")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Halfmountrange { get; set; }

        [JsonPropertyName("@forceddismountcooldown")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Forceddismountcooldown { get; set; }

        [JsonPropertyName("@forceddismountspellcooldown")]
        public string Forceddismountspellcooldown { get; set; }

        [JsonPropertyName("@fulldismountcooldown")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Fulldismountcooldown { get; set; }

        [JsonPropertyName("@remounttime")]
        public string Remounttime { get; set; }

        [JsonPropertyName("@uicraftsoundstart")]
        public string Uicraftsoundstart { get; set; }

        [JsonPropertyName("@uicraftsoundfinish")]
        public string Uicraftsoundfinish { get; set; }

        [JsonPropertyName("@dismountbuff")]
        public string Dismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@forceddismountbuff")]
        public string? Forceddismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hostiledismountbuff")]
        public string? Hostiledismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@longhostiledismountbuff")]
        public string? Longhostiledismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Showinmarketplace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hidefromplayeroncontext")]
        public string? Hidefromplayeroncontext { get; set; }

        [JsonPropertyName("@vfxAddonKeyword")]
        public string VfxAddonKeyword { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingspelllist")]
        public EquipmentitemCraftingspelllist Craftingspelllist { get; set; }

        [JsonPropertyName("SocketPreset")]
        public AudioInfo SocketPreset { get; set; }

        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetVfxPreset")]
        public AudioInfo AssetVfxPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FootStepVfxPreset")]
        public AudioInfo FootStepVfxPreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canusetownportal")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Canusetownportal { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@halfmountprefaboverride")]
        public string Halfmountprefaboverride { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@nametagoffset")]
        public string Nametagoffset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canuseingvg")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Canuseingvg { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mountspelllist")]
        public Mountspelllist Mountspelllist { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canuseinfactionwarfare")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Canuseinfactionwarfare { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Itemvalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public string Descriptionlocatag { get; set; }
    }
}

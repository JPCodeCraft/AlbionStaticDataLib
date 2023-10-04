using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Mount : ICraftableItem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@mountcategory")]
        public MountCategory Mountcategory { get; set; }

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
        public ShopsubcategoryName Shopsubcategory { get; set; }

        [JsonPropertyName("@mountedbuff")]
        public string Mountedbuff { get; set; }

        [JsonPropertyName("@halfmountedbuff")]
        public string Halfmountedbuff { get; set; }

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

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Durability { get; set; }

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
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Unlockedtocraft { get; set; }

        [JsonPropertyName("@unlockedtoequip")]
        [JsonConverter(typeof(StringToBoolConverter))]
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
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Mounthitpointsregeneration { get; set; }

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
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Forceddismountspellcooldown { get; set; }

        [JsonPropertyName("@fulldismountcooldown")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Fulldismountcooldown { get; set; }

        [JsonPropertyName("@remounttime")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Remounttime { get; set; }

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
        [JsonConverter(typeof(StringToBoolConverter))]
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
        public Craftingspelllist Craftingspelllist { get; set; }

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
        [JsonConverter(typeof(StringToBoolConverter))]
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
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Canuseingvg { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mountspelllist")]
        public Mountspelllist Mountspelllist { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int? Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canuseinfactionwarfare")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Canuseinfactionwarfare { get; set; }

        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Itemvalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public string Descriptionlocatag { get; set; }
    }
}

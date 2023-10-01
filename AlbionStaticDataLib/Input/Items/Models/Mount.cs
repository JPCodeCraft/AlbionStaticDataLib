﻿using System.Text.Json.Serialization;
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
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Maxqualitylevel { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@slottype")]
        public Slottype Slottype { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public string Shopsubcategory1 { get; set; }

        [JsonPropertyName("@mountedbuff")]
        public string Mountedbuff { get; set; }

        [JsonPropertyName("@halfmountedbuff")]
        public string Halfmountedbuff { get; set; }

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
        public string Durability { get; set; }

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

        [JsonPropertyName("@durabilityloss_receivedattack_mounted")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossReceivedattackMounted { get; set; }

        [JsonPropertyName("@durabilityloss_receivedspell_mounted")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossReceivedspellMounted { get; set; }

        [JsonPropertyName("@durabilityloss_mounting")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long DurabilitylossMounting { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@unlockedtoequip")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtoequip { get; set; }

        [JsonPropertyName("@mounttime")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Mounttime { get; set; }

        [JsonPropertyName("@dismounttime")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Dismounttime { get; set; }

        [JsonPropertyName("@mounthitpointsmax")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Mounthitpointsmax { get; set; }

        [JsonPropertyName("@mounthitpointsregeneration")]
        public string Mounthitpointsregeneration { get; set; }

        [JsonPropertyName("@prefabname")]
        public string Prefabname { get; set; }

        [JsonPropertyName("@prefabscaling")]
        public string Prefabscaling { get; set; }

        [JsonPropertyName("@despawneffect")]
        public Despawneffect Despawneffect { get; set; }

        [JsonPropertyName("@despawneffectscaling")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Despawneffectscaling { get; set; }

        [JsonPropertyName("@remountdistance")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Remountdistance { get; set; }

        [JsonPropertyName("@halfmountrange")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Halfmountrange { get; set; }

        [JsonPropertyName("@forceddismountcooldown")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Forceddismountcooldown { get; set; }

        [JsonPropertyName("@forceddismountspellcooldown")]
        public string Forceddismountspellcooldown { get; set; }

        [JsonPropertyName("@fulldismountcooldown")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Fulldismountcooldown { get; set; }

        [JsonPropertyName("@remounttime")]
        public string Remounttime { get; set; }

        [JsonPropertyName("@uicraftsoundstart")]
        public MountUicraftsoundstart Uicraftsoundstart { get; set; }

        [JsonPropertyName("@uicraftsoundfinish")]
        public MountUicraftsoundfinish Uicraftsoundfinish { get; set; }

        [JsonPropertyName("@dismountbuff")]
        public Dismountbuff Dismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@forceddismountbuff")]
        public Forceddismountbuff? Forceddismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hostiledismountbuff")]
        public Hostiledismountbuff? Hostiledismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@longhostiledismountbuff")]
        public Longhostiledismountbuff? Longhostiledismountbuff { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Showinmarketplace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hidefromplayeroncontext")]
        public Hidefromplayeroncontext? Hidefromplayeroncontext { get; set; }

        [JsonPropertyName("@vfxAddonKeyword")]
        public string VfxAddonKeyword { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public MountCraftingrequirements Craftingrequirements { get; set; }

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
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@canuseinfactionwarfare")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Canuseinfactionwarfare { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Itemvalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public string Descriptionlocatag { get; set; }
    }
}
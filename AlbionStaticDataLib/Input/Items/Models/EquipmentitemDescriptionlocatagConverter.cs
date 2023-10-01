using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EquipmentitemDescriptionlocatagConverter : JsonConverter<EquipmentitemDescriptionlocatag>
    {
        public override bool CanConvert(Type t) => t == typeof(EquipmentitemDescriptionlocatag);

        public override EquipmentitemDescriptionlocatag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "@ITEMS_CAPEITEM_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsCapeitemDesc;
                case "@ITEMS_DECORATIVE_EQUIPMENT_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsDecorativeEquipmentDesc;
                case "@ITEMS_GENERAL_BAG_INSIGHT_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsGeneralBagInsightDesc;
                case "@ITEMS_GENERAL_EQUIPMENT_ITEM_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsGeneralEquipmentItemDesc;
                case "@ITEMS_T1_ARMOR_LEATHER_SET1_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsT1ArmorLeatherSet1Desc;
                case "@ITEMS_T2_ARMOR_CLOTH_SET1_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsT2ArmorClothSet1Desc;
                case "@ITEMS_T2_ARMOR_PLATE_SET1_DESC":
                    return EquipmentitemDescriptionlocatag.ItemsT2ArmorPlateSet1Desc;
            }
            throw new Exception("Cannot unmarshal type EquipmentitemDescriptionlocatag");
        }

        public override void Write(Utf8JsonWriter writer, EquipmentitemDescriptionlocatag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EquipmentitemDescriptionlocatag.ItemsCapeitemDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_CAPEITEM_DESC", options);
                    return;
                case EquipmentitemDescriptionlocatag.ItemsDecorativeEquipmentDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_DECORATIVE_EQUIPMENT_DESC", options);
                    return;
                case EquipmentitemDescriptionlocatag.ItemsGeneralBagInsightDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_GENERAL_BAG_INSIGHT_DESC", options);
                    return;
                case EquipmentitemDescriptionlocatag.ItemsGeneralEquipmentItemDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_GENERAL_EQUIPMENT_ITEM_DESC", options);
                    return;
                case EquipmentitemDescriptionlocatag.ItemsT1ArmorLeatherSet1Desc:
                    JsonSerializer.Serialize(writer, "@ITEMS_T1_ARMOR_LEATHER_SET1_DESC", options);
                    return;
                case EquipmentitemDescriptionlocatag.ItemsT2ArmorClothSet1Desc:
                    JsonSerializer.Serialize(writer, "@ITEMS_T2_ARMOR_CLOTH_SET1_DESC", options);
                    return;
                case EquipmentitemDescriptionlocatag.ItemsT2ArmorPlateSet1Desc:
                    JsonSerializer.Serialize(writer, "@ITEMS_T2_ARMOR_PLATE_SET1_DESC", options);
                    return;
            }
            throw new Exception("Cannot marshal type EquipmentitemDescriptionlocatag");
        }

        public static readonly EquipmentitemDescriptionlocatagConverter Singleton = new EquipmentitemDescriptionlocatagConverter();
    }
}

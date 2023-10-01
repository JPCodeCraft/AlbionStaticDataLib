using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EquipmentitemCraftingcategoryConverter : JsonConverter<EquipmentitemCraftingcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(EquipmentitemCraftingcategory);

        public override EquipmentitemCraftingcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "bag":
                    return EquipmentitemCraftingcategory.Bag;
                case "cape":
                    return EquipmentitemCraftingcategory.Cape;
                case "cloth_armor":
                    return EquipmentitemCraftingcategory.ClothArmor;
                case "cloth_helmet":
                    return EquipmentitemCraftingcategory.ClothHelmet;
                case "cloth_shoes":
                    return EquipmentitemCraftingcategory.ClothShoes;
                case "gatherergear":
                    return EquipmentitemCraftingcategory.Gatherergear;
                case "leather_armor":
                    return EquipmentitemCraftingcategory.LeatherArmor;
                case "leather_helmet":
                    return EquipmentitemCraftingcategory.LeatherHelmet;
                case "leather_shoes":
                    return EquipmentitemCraftingcategory.LeatherShoes;
                case "offhand":
                    return EquipmentitemCraftingcategory.Offhand;
                case "plate_armor":
                    return EquipmentitemCraftingcategory.PlateArmor;
                case "plate_helmet":
                    return EquipmentitemCraftingcategory.PlateHelmet;
                case "plate_shoes":
                    return EquipmentitemCraftingcategory.PlateShoes;
            }
            throw new Exception("Cannot unmarshal type EquipmentitemCraftingcategory");
        }

        public override void Write(Utf8JsonWriter writer, EquipmentitemCraftingcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EquipmentitemCraftingcategory.Bag:
                    JsonSerializer.Serialize(writer, "bag", options);
                    return;
                case EquipmentitemCraftingcategory.Cape:
                    JsonSerializer.Serialize(writer, "cape", options);
                    return;
                case EquipmentitemCraftingcategory.ClothArmor:
                    JsonSerializer.Serialize(writer, "cloth_armor", options);
                    return;
                case EquipmentitemCraftingcategory.ClothHelmet:
                    JsonSerializer.Serialize(writer, "cloth_helmet", options);
                    return;
                case EquipmentitemCraftingcategory.ClothShoes:
                    JsonSerializer.Serialize(writer, "cloth_shoes", options);
                    return;
                case EquipmentitemCraftingcategory.Gatherergear:
                    JsonSerializer.Serialize(writer, "gatherergear", options);
                    return;
                case EquipmentitemCraftingcategory.LeatherArmor:
                    JsonSerializer.Serialize(writer, "leather_armor", options);
                    return;
                case EquipmentitemCraftingcategory.LeatherHelmet:
                    JsonSerializer.Serialize(writer, "leather_helmet", options);
                    return;
                case EquipmentitemCraftingcategory.LeatherShoes:
                    JsonSerializer.Serialize(writer, "leather_shoes", options);
                    return;
                case EquipmentitemCraftingcategory.Offhand:
                    JsonSerializer.Serialize(writer, "offhand", options);
                    return;
                case EquipmentitemCraftingcategory.PlateArmor:
                    JsonSerializer.Serialize(writer, "plate_armor", options);
                    return;
                case EquipmentitemCraftingcategory.PlateHelmet:
                    JsonSerializer.Serialize(writer, "plate_helmet", options);
                    return;
                case EquipmentitemCraftingcategory.PlateShoes:
                    JsonSerializer.Serialize(writer, "plate_shoes", options);
                    return;
            }
            throw new Exception("Cannot marshal type EquipmentitemCraftingcategory");
        }

        public static readonly EquipmentitemCraftingcategoryConverter Singleton = new EquipmentitemCraftingcategoryConverter();
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class WeaponDescriptionlocatagConverter : JsonConverter<WeaponDescriptionlocatag>
    {
        public override bool CanConvert(Type t) => t == typeof(WeaponDescriptionlocatag);

        public override WeaponDescriptionlocatag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "@ITEMS_GENERAL_EQUIPMENT_ITEM_DESC":
                    return WeaponDescriptionlocatag.ItemsGeneralEquipmentItemDesc;
                case "@ITEMS_T8_2H_TOOL_SIEGEHAMMER_DESC":
                    return WeaponDescriptionlocatag.ItemsT82HToolSiegehammerDesc;
            }
            throw new Exception("Cannot unmarshal type WeaponDescriptionlocatag");
        }

        public override void Write(Utf8JsonWriter writer, WeaponDescriptionlocatag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case WeaponDescriptionlocatag.ItemsGeneralEquipmentItemDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_GENERAL_EQUIPMENT_ITEM_DESC", options);
                    return;
                case WeaponDescriptionlocatag.ItemsT82HToolSiegehammerDesc:
                    JsonSerializer.Serialize(writer, "@ITEMS_T8_2H_TOOL_SIEGEHAMMER_DESC", options);
                    return;
            }
            throw new Exception("Cannot marshal type WeaponDescriptionlocatag");
        }

        public static readonly WeaponDescriptionlocatagConverter Singleton = new WeaponDescriptionlocatagConverter();
    }
}

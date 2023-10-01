namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct EquipmentitemCraftingrequirements
    {
        public List<FluffyCraftingrequirement> FluffyCraftingrequirementArray;
        public TentacledCraftingrequirements TentacledCraftingrequirements;

        public static implicit operator EquipmentitemCraftingrequirements(List<FluffyCraftingrequirement> FluffyCraftingrequirementArray) => new EquipmentitemCraftingrequirements { FluffyCraftingrequirementArray = FluffyCraftingrequirementArray };
        public static implicit operator EquipmentitemCraftingrequirements(TentacledCraftingrequirements TentacledCraftingrequirements) => new EquipmentitemCraftingrequirements { TentacledCraftingrequirements = TentacledCraftingrequirements };
    }
}

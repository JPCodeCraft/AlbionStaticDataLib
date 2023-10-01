namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct FurnitureitemCraftingrequirements
    {
        public List<PurpleCraftingrequirement> PurpleCraftingrequirementArray;
        public StickyCraftingrequirements StickyCraftingrequirements;

        public static implicit operator FurnitureitemCraftingrequirements(List<PurpleCraftingrequirement> PurpleCraftingrequirementArray) => new FurnitureitemCraftingrequirements { PurpleCraftingrequirementArray = PurpleCraftingrequirementArray };
        public static implicit operator FurnitureitemCraftingrequirements(StickyCraftingrequirements StickyCraftingrequirements) => new FurnitureitemCraftingrequirements { StickyCraftingrequirements = StickyCraftingrequirements };
    }
}

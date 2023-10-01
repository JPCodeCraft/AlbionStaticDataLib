namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct ConsumablefrominventoryitemCraftingrequirements
    {
        public List<PurpleCraftingrequirement> PurpleCraftingrequirementArray;
        public PurpleCraftingrequirements PurpleCraftingrequirements;

        public static implicit operator ConsumablefrominventoryitemCraftingrequirements(List<PurpleCraftingrequirement> PurpleCraftingrequirementArray) => new ConsumablefrominventoryitemCraftingrequirements { PurpleCraftingrequirementArray = PurpleCraftingrequirementArray };
        public static implicit operator ConsumablefrominventoryitemCraftingrequirements(PurpleCraftingrequirements PurpleCraftingrequirements) => new ConsumablefrominventoryitemCraftingrequirements { PurpleCraftingrequirements = PurpleCraftingrequirements };
    }
}

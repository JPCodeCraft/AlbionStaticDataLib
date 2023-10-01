namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct LootUnion
    {
        public LootElement LootElement;
        public List<LootElement> LootElementArray;

        public static implicit operator LootUnion(LootElement LootElement) => new LootUnion { LootElement = LootElement };
        public static implicit operator LootUnion(List<LootElement> LootElementArray) => new LootUnion { LootElementArray = LootElementArray };
    }
}

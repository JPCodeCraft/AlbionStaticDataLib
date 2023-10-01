namespace AlbionStaticDataLib.Input.Resources.Models
{
    public struct TierUnion
    {
        public TierElement TierElement;
        public List<TierElement> TierElementArray;

        public static implicit operator TierUnion(TierElement TierElement) => new TierUnion { TierElement = TierElement };
        public static implicit operator TierUnion(List<TierElement> TierElementArray) => new TierUnion { TierElementArray = TierElementArray };
    }
}

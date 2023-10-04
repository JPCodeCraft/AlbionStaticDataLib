using AlbionStaticDataLib.Json.Items.Models;

namespace AlbionStaticDataLib.Interfaces
{
    public interface ICraftableItem : IBaseItem
    {
        public List<Craftingrequirements>? Craftingrequirements { get; set; }
    }
}

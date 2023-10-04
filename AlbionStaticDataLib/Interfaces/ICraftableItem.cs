using AlbionStaticDataLib.Json.Items.Models;

namespace AlbionStaticDataLib.Interfaces
{
    internal interface ICraftableItem
    {
        public List<Craftingrequirements>? Craftingrequirements { get; set; }
    }
}

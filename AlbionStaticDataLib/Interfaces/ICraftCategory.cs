using AlbionStaticDataLib.Json.Items.Models;

namespace AlbionStaticDataLib.Interfaces
{
    public interface ICraftCategory : ICraftableItem
    {
        Craftingcategory? Craftingcategory { get; set; }
    }
}

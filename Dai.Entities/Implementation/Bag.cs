using System.Collections.ObjectModel;
using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public class Bag : BaseEFEntity
{
    public virtual ICollection<Item?> Items { get; set; }
    public int Size { get; set; }
}
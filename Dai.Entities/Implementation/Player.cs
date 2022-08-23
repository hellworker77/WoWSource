using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public class Player : AbstractEntity
{
    public virtual Bag? Bag { get; set; }
    public virtual Inventory Inventory { get; set; }


}
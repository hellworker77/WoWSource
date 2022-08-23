using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public class Inventory : BaseEFEntity
{
    public virtual Item? Helm { get; set; }
    public virtual Item? Chestplate { get; set; }
    public virtual Item? Bracers { get; set; }
    public virtual Item? Pants { get; set; }
    public virtual Item? Belt { get; set; }
    public virtual Item? Boots { get; set; }
    public virtual Item? Gloves { get; set; }
    public virtual Item? Shoulders { get; set; }
    public virtual Item? Amulet { get; set; }
    public virtual Item? RingRight { get; set; }
    public virtual Item? RingLeft { get; set; }
    public virtual Item? Weapon { get; set; }
    public virtual Item? OffHand { get; set; }


}
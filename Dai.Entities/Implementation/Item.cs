using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public enum ItemRarity
{
    None = 0,
    Common,
    Uncommon,
    Magic,
    Rare,
    Epic,
    Legendary
}

public enum ItemType
{
    None,
    Helm,
    Chestplate,
    Pants,
    Boots,
    Belt,
    Gloves,
    Shoulders,
    Bracers,
    Amulet,
    RingRight,
    RingLeft,
    Weapon,
    OffHand
}
public class Item : BaseEFEntity
{
    public string? Name { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }
    public int ItemLevel { get; set; }
    public string? Image { get; set; }
    public virtual ItemRarity Rarity { get; set; }
    public virtual ItemType Type { get; set; }
}
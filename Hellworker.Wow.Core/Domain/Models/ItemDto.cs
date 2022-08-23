using Dai.Entities.Implementation;

namespace Hellworker.Wow.Core.Domain.Models;

public class ItemDto
{
    public string? Name { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }
    public int ItemLevel { get; set; }
    public string? Image { get; set; }
    public ItemRarity Rarity { get; set; }
    public ItemType Type { get; set; }
    public int GetHealth()
    {
        return Health + (int)Rarity * ItemLevel;
    }
    public int GetArmor()
    {
        return Defense + (int)Rarity * ItemLevel;
    }
    public int GetDamage()
    {
        return Damage + (int)Rarity * ItemLevel; ;
    }

    public void SetSourceValue(ItemDto? source)
    {
        Damage = source?.Damage ?? 0;
        Defense = source?.Defense ?? 0;
        Health = source?.Health ?? 0;
        Rarity = source?.Rarity ?? ItemRarity.None;
        Type = source?.Type ?? ItemType.None;
        ItemLevel = source?.ItemLevel ?? 0;
        Name = source?.Name ?? null;
        Image = source?.Image ?? null;
    }
}
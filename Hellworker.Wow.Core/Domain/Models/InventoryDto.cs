using Dai.Entities.Implementation;

namespace Hellworker.Wow.Core.Domain.Models;

public class InventoryDto
{
    public ItemDto? Helm { get; set; }
    public ItemDto? Chestplate { get; set; }
    public ItemDto? Bracers { get; set; }
    public ItemDto? Pants { get; set; }
    public ItemDto? Belt { get; set; }
    public ItemDto? Boots { get; set; }
    public ItemDto? Gloves { get; set; }
    public ItemDto? Shoulders { get; set; }
    public ItemDto? Amulet { get; set; }
    public ItemDto? RingRight { get; set; }
    public ItemDto? RingLeft { get; set; }
    public ItemDto? Weapon { get; set; }
    public ItemDto? OffHand { get; set; }

    public int GetHealth()
    {
        var result = 0;
        result += Chestplate?.GetHealth() ?? 0;
        result += Weapon?.GetHealth() ?? 0;
        result += Helm?.GetHealth() ?? 0;
        result += Bracers?.GetHealth() ?? 0;
        result += Pants?.GetHealth() ?? 0;
        result += Belt?.GetHealth() ?? 0;
        result += Boots?.GetHealth() ?? 0;
        result += Gloves?.GetHealth() ?? 0;
        result += Shoulders?.GetHealth() ?? 0;
        result += Amulet?.GetHealth() ?? 0;
        result += RingLeft?.GetHealth() ?? 0;
        result += RingRight?.GetHealth() ?? 0;
        result += OffHand?.GetHealth() ?? 0;
        return result;
    }
    public int GetArmor()
    {
        var result = 0;
        result += Chestplate?.GetArmor() ?? 0;
        result += Weapon?.GetArmor() ?? 0;
        result += Helm?.GetArmor() ?? 0;
        result += Bracers?.GetArmor() ?? 0;
        result += Pants?.GetArmor() ?? 0;
        result += Belt?.GetArmor() ?? 0;
        result += Boots?.GetArmor() ?? 0;
        result += Gloves?.GetArmor() ?? 0;
        result += Shoulders?.GetArmor() ?? 0;
        result += Amulet?.GetArmor() ?? 0;
        result += RingLeft?.GetArmor() ?? 0;
        result += RingRight?.GetArmor() ?? 0;
        result += OffHand?.GetArmor() ?? 0;
        return result;
    }
    public int GetDamage()
    {
        var result = 0;
        result += Chestplate?.GetDamage() ?? 0;
        result += Weapon?.GetDamage() ?? 0;
        result += Helm?.GetDamage() ?? 0;
        result += Bracers?.GetDamage() ?? 0;
        result += Pants?.GetDamage() ?? 0;
        result += Belt?.GetDamage() ?? 0;
        result += Boots?.GetDamage() ?? 0;
        result += Gloves?.GetDamage() ?? 0;
        result += Shoulders?.GetDamage() ?? 0;
        result += Amulet?.GetDamage() ?? 0;
        result += RingLeft?.GetDamage() ?? 0;
        result += RingRight?.GetDamage() ?? 0;
        result += OffHand?.GetDamage() ?? 0;
        return result;
    }
}
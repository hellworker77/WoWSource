using Hellworker.Wow.Core.Domain.Abstractions;

namespace Hellworker.Wow.Core.Domain.Models;

public class PlayerDto : AbstractEntityDto
{
    public int HealthBoost
    {
        get => _healthBoost;
        set => _healthBoost = value;
    }
    public BagDto? Bag { get; set; }

    public int DefenseBoost
    {
        get => _defenseBoost;
        set => _defenseBoost = value;

    }
    public int DamageBoost
    {
        get => _damageBoost;
        set => _damageBoost = value;
    }
    public override int Health
    {
        get => base.Health + _healthBoost;
    }
    public override int Damage
    {
        get => base.Damage + _damageBoost;
    }
    public override int Defense
    {
        get => base.Defense + _defenseBoost;
    }
    public virtual InventoryDto Inventory { get; set; }


    public void Update()
    {
        HealthBoost = Inventory?.GetHealth() ?? 0;
        DamageBoost = Inventory?.GetArmor() ?? 0;
        DefenseBoost = Inventory?.GetArmor() ?? 0;
        CurrentHealth = Health;
    }

    public string GetRarity()
    {
        var result = string.Empty;
        var power = Health + Defense + Damage;

        if (power < 300)
        {
            result = "common";
        }
        else if (power < 1400)
        {
            result = "uncommon";
        }
        else if (power < 3200)
        {
            result = "rare";
        }
        else if (power < 8300)
        {
            result = "epic";
        }
        else
        {
            result = "legendary";
        }

        return result;
    }

    public override string? ImageHead
    {
        get
        {
            var rarity = GetRarity();
            var result = $"/Images/Skins/{rarity}head.png";
            return result;
        }
    }
    public override string Image
    {
        get
        {
            var rarity = GetRarity();
            var result = $"/Images/Skins/{rarity}.jpg";
            return result;
        }
    }

    private int _healthBoost;
    private int _damageBoost;
    private int _defenseBoost;
}
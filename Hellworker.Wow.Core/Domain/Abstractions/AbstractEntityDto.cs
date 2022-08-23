namespace Hellworker.Wow.Core.Domain.Abstractions;

public class AbstractEntityDto
{
    public string Name { get; set; }
    public virtual int Health
    {
        get => _health;
        set => _health = value;
    }
    public virtual int Damage
    {
        get => _damage;
        set => _damage = value;
    }
    public virtual int Defense
    {
        get => _defense;
        set => _defense = value;
    }
    public virtual string? Image
    {
        get => _image;
        set => _image = value;

    }
    public virtual string? ImageHead
    {
        get => _imageHead;
        set => _imageHead = value;
    }
    public bool IsDeath
    {
        get => _isDeath;
        set => _isDeath = value;
    }
    public bool IsDefeated
    {
        get => _isDefeated;
        set
        {
            _isDefeated = value;
            if (_isDefeated == false)
            {
                CurrentHealth = Health;
                _isDeath = false;
            }
        }
    }
    public int CurrentHealth
    {
        get => _currentHealth;
        set
        {
            _currentHealth = value;
            BarWidth = (int)Convert.ToSingle(_currentHealth * 280 / Health);
        }
    }
    public int Level { get; set; }
    public int BarWidth { get; set; }
    public string HealthString
    {
        get
        {
            var percents = Math.Round(CurrentHealth * 100f / Health, 2);
            var result = $"{CurrentHealth}/{Health} {percents}%";

            if (IsDeath)
            {
                result = "Death";
            }
            return result;
        }
        set
        {
            return;
        }
    }

    public virtual void Heal()
    {
        CurrentHealth = Health;
    }

    public virtual void Resurrect()
    {
        IsDeath = false;
    }

    public virtual int GetHit(AbstractEntityDto attacker)
    {
        if (attacker.IsDeath)
        {
            attacker.Resurrect();
            return -1;
        }
        var hurt = (attacker.Damage * attacker.Damage) / (this.Defense + attacker.Damage);
        if (hurt < 1)
        {
            hurt = 1;
        }

        var absorbed = attacker.Damage - hurt;
        CurrentHealth -= hurt;

        if (CurrentHealth <= 0)
        {
            attacker.OnVictory();
            OnDeath();
        }

        return absorbed;
    }

    protected virtual void OnDeath()
    {
        CurrentHealth = 0;
        IsDeath = true;
        IsDefeated = true;
    }
    protected virtual void OnVictory()
    {
        CurrentHealth = Health;
    }


    private int _currentHealth;
    private bool _isDeath;
    private bool _isDefeated;
    private int _health;
    private int _damage;
    private int _defense;
    private string? _image;
    private string? _imageHead;
}
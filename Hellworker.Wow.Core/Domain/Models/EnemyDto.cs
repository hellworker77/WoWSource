using Hellworker.Wow.Core.Domain.Abstractions;

namespace Hellworker.Wow.Core.Domain.Models;

public class EnemyDto : AbstractEntityDto
{
    public int NeedToKill
    {
        get => _needToKill;
        set => _needToKill = value;
    }
    public int CurrentKill
    {
        get => _currentKill;
        set => _currentKill = value;
    }

    protected override void OnDeath()
    {
        _currentKill++;
        CurrentHealth = Health;
        IsDeath = true;
        if (_currentKill >= _needToKill)
        {
            OnDefeated();
        }
    }

    private void OnDefeated()
    {
        _currentKill = 0;
        IsDefeated = true;
        IsDeath = false;
        CurrentHealth = Health;
    }
    private int _needToKill;
    private int _currentKill;
}
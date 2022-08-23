namespace Hellworker.Wow.Core.Domain.Models;

public class LocationDto
{
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Background { get; set; }

    public void Restart()
    {
        Enemies.Select(x =>
        {
            x.IsDefeated = false;
            return x;
        }).ToList();
    }

    public virtual ICollection<EnemyDto> Enemies { get; set; }
}
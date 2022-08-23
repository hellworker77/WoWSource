using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public class Location : BaseEFEntity
{
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Background { get; set; }
    public virtual WayPoint WayPoint { get; set; }
    public virtual ICollection<Enemy> Enemies { get; set; }


}
using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public class Enemy : AbstractEntity
{
    public int NeedToKill { get; set; }


    public virtual Location Location { get; set; }
    public Guid LocationId { get; set; }
}
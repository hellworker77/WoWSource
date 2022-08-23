using Dai.Entities.Abstractions;

namespace Dai.Entities.Implementation;

public class WayPoint : BaseEFEntity
{
    public virtual Location Location { get; set; }
    public Guid LocationId { get; set; }
}
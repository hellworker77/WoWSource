using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Hellworker.Wow.DataAccess.Abstractions;

public interface IWayPointsRepository
{
    public IEnumerable<WayPointDto> GetAll();
}
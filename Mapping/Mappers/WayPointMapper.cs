using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class WayPointMapper : Profile
{
    public WayPointMapper()
    {
        CreateMap<WayPoint, WayPointDto>();
    }
}
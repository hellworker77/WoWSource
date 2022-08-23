using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class LocationMapper : Profile
{
    public LocationMapper()
    {
        CreateMap<Location, LocationDto>();
    }
}
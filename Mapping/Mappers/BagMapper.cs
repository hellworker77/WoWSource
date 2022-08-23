using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class BagMapper : Profile
{
    public BagMapper()
    {
        CreateMap<Bag, BagDto>();
    }
}
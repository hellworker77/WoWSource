using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class ItemMapper : Profile
{
    public ItemMapper()
    {
        CreateMap<Item, ItemDto>();
    }
}
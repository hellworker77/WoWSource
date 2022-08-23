using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class InventoryMapper : Profile
{
    public InventoryMapper()
    {
        CreateMap<Inventory, InventoryDto>();
    }
}
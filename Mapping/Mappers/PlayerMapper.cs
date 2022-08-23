using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class PlayerMapper : Profile
{
    public PlayerMapper()
    {
        CreateMap<Player, PlayerDto>();
    }
}
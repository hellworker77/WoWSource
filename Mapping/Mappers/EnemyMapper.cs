using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;

namespace Mapping.Mappers;

public class EnemyMapper : Profile
{
    public EnemyMapper()
    {
        CreateMap<Enemy, EnemyDto>();
    }
}
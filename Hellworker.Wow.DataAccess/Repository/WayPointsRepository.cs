using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;
using Hellworker.Wow.DataAccess.Abstractions;
using Hellworker.Wow.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Hellworker.Wow.DataAccess.Repository;

public class WayPointsRepository : IWayPointsRepository
{
    private ApplicationContext _context;
    private DbSet<WayPoint> _dbSet;
    private readonly IMapper _mapper;
    public WayPointsRepository(ApplicationContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
        _dbSet = _context.Set<WayPoint>();
    }
    public IEnumerable<WayPointDto> GetAll()
    {
        return _dbSet.Select(x=>_mapper.Map<WayPointDto>(x)).ToList();
    }
}
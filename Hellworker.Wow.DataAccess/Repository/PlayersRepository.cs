using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;
using Hellworker.Wow.DataAccess.Abstractions;
using Hellworker.Wow.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Hellworker.Wow.DataAccess.Repository;

public class PlayersRepository : IPlayersRepository
{
    private ApplicationContext _context;
    private DbSet<Player> _dbSet;
    private readonly IMapper _mapper;
    public PlayersRepository(ApplicationContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
        _dbSet = _context.Set<Player>();
    }
    public IEnumerable<PlayerDto> GetAll()
    {
        return _dbSet.Select(x=>_mapper.Map<PlayerDto>(x)).ToList();
    }
}
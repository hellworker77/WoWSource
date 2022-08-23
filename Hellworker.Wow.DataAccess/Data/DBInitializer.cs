using Hellworker.Wow.DataAccess.Abstractions;

namespace Hellworker.Wow.DataAccess.Data;

public class DBInitializer : IDBInitializer
{
    private ApplicationContext _context;
    public DBInitializer(ApplicationContext context)
    {
        _context = context;
    }
    public void Initialize()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();

        _context.Items.AddRange(FakeData.Items);
        _context.SaveChanges();

        _context.Bags.AddRange(FakeData.Bags);
        _context.SaveChanges();

        _context.Inventories.AddRange(FakeData.Inventories);
        _context.SaveChanges();

        _context.Players.AddRange(FakeData.Players);
        _context.SaveChanges();

        //_context.Enemies.AddRange(FakeData.Enemies);
        //_context.SaveChanges();

        _context.Locations.AddRange(FakeData.Locations);
        _context.SaveChanges();

        _context.WayPoints.AddRange(FakeData.WayPoints);
        _context.SaveChanges();
    }
}
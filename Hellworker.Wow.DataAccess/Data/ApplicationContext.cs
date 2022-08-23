using Dai.Entities.Implementation;
using Hellworker.Wow.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Hellworker.Wow.DataAccess.Data;

public class ApplicationContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Bag> Bags { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Enemy> Enemies { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<WayPoint> WayPoints { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> contextOptionsBuilder)
        : base(contextOptionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new BagConfiguration());
        builder.ApplyConfiguration(new PlayerConfiguration());
        builder.ApplyConfiguration(new WayPointConfiguration());
        builder.ApplyConfiguration(new LocationConfiguration());
        builder.ApplyConfiguration(new EnemyConfiguration());
    }
}
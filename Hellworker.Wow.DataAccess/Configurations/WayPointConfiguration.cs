using Dai.Entities.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hellworker.Wow.DataAccess.Configurations;

public class WayPointConfiguration : IEntityTypeConfiguration<WayPoint>
{
    public void Configure(EntityTypeBuilder<WayPoint> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Location).WithOne(x => x.WayPoint).HasForeignKey<WayPoint>(x => x.LocationId).IsRequired();

    }
}
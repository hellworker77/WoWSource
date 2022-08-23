using Dai.Entities.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hellworker.Wow.DataAccess.Configurations;

public class EnemyConfiguration : IEntityTypeConfiguration<Enemy>
{
    public void Configure(EntityTypeBuilder<Enemy> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Location).WithMany(x => x.Enemies).HasForeignKey(x => x.LocationId).IsRequired();

    }
}
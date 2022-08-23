using Dai.Entities.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hellworker.Wow.DataAccess.Configurations;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Ignore(x => x.Image);
        builder.Ignore(x=>x.ImageHead);
        //builder.HasOne(t => t.Tour).WithMany(b => b.Bookings).HasForeignKey(k => k.Id).IsRequired();

        //builder.HasOne(u => u.User).WithMany(b => b.Bookings).HasForeignKey(k => k.Id).IsRequired();

    }
}
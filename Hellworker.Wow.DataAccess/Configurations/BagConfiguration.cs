using Dai.Entities.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hellworker.Wow.DataAccess.Configurations;

public class BagConfiguration : IEntityTypeConfiguration<Bag>
{
    public void Configure(EntityTypeBuilder<Bag> builder)
    {
        builder.HasKey(bag => bag.Id);
        //builder.HasOne(t => t.Tour).WithMany(b => b.Bookings).HasForeignKey(k => k.Id).IsRequired();

        //builder.HasOne(u => u.User).WithMany(b => b.Bookings).HasForeignKey(k => k.Id).IsRequired();

    }
}
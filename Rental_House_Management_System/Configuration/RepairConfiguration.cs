using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Configuration
{
    public class RepairConfiguration : IEntityTypeConfiguration<Repair>
    {
        public void Configure(EntityTypeBuilder<Repair> builder)
        {
            builder.ToTable("repairs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Room);
            builder.Property(x => x.Description);
            builder.Property(x => x.State).HasDefaultValue(false);
        }
    }

}

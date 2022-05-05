using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Configuration
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("bookings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Note);
            builder.Property(x => x.Status).HasDefaultValue("Waiting");
        }
    }
}

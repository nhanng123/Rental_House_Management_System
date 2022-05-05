using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Configuration;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
        }

        public DbSet<Booking> Bookings { get; set; }
    }
}

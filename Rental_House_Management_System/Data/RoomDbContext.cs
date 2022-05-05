using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Configuration;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Data
{
    public class RoomDbContext : DbContext
    {
        public RoomDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
        }
        public DbSet<Room> Rooms { get; set; }
    }
}

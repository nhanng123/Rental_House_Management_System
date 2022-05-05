using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Configuration;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Data
{
    public class BillDbContext : DbContext
    {
        public BillDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BillConfiguration());
        }


        public DbSet<Bill> bills { get; set; }
    }
}

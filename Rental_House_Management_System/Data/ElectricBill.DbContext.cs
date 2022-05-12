using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Configuration;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Data
{
    public class ElectricBillDbContext : DbContext
    {
        public ElectricBillDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ElectricBillConfiguration());
        }
        public DbSet<ElectricBill> electricBills { get; set; }
    }
}

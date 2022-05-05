using Microsoft.EntityFrameworkCore;
using Rental_House_Management_System.Configuration;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }

        public DbSet<Customer> customers { get; set; }
    }
}

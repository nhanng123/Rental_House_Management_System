using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rental_House_Management_System.Data
{
    public class RepairDbContextFactory : IDesignTimeDbContextFactory<RepairDbContext>
    {
        public RepairDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("RetalHousesDatabase");

            var optionBuilder = new DbContextOptionsBuilder<RepairDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new RepairDbContext(optionBuilder.Options);
        }
    }
}

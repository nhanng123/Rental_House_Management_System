using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rental_House_Management_System.Data
{
    public class ElectricBillDbContextFactory : IDesignTimeDbContextFactory<ElectricBillDbContext>
    {
        public ElectricBillDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("RetalHousesDatabase");

            var optionBuilder = new DbContextOptionsBuilder<ElectricBillDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new ElectricBillDbContext(optionBuilder.Options);
        }
    }

}

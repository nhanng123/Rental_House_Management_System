using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rental_House_Management_System.Data
{
    public class BillDbContextFactory : IDesignTimeDbContextFactory<BillDbContext>
    {
        public BillDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("RetalHousesDatabase");

            var optionBuilder = new DbContextOptionsBuilder<BillDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new BillDbContext(optionBuilder.Options);
        }
    }

}

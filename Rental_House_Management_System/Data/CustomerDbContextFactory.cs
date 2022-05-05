using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rental_House_Management_System.Data
{
    public class CustomerDbContextFactory : IDesignTimeDbContextFactory<CustomerDbContext>
    {
        public CustomerDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("RetalHousesDatabase");

            var optionBuilder = new DbContextOptionsBuilder<CustomerDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new CustomerDbContext(optionBuilder.Options);
        }

      
    }


}

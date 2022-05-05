using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rental_House_Management_System.Data
{
    public class RoomDbContextFactory : IDesignTimeDbContextFactory<RoomDbContext>
    {
        public RoomDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("RetalHousesDatabase");

            var optionBuilder = new DbContextOptionsBuilder<RoomDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new RoomDbContext(optionBuilder.Options);
        }
    }
}

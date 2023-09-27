using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoffeeShop.Data.EF
{
    public class EshopSolutionDbContextFactory : IDesignTimeDbContextFactory<CoffeeShopDBContext>
    {   
        public CoffeeShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("coffeeShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<CoffeeShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CoffeeShopDBContext(optionsBuilder.Options);
        }
    }
}

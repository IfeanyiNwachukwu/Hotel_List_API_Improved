using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL
{
    public class DesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
    {
        public T CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();

            var builder = new DbContextOptionsBuilder<T>();
            var connectionString = configuration.GetConnectionString("sqlConnection");
            builder.UseSqlServer(connectionString);

            var dbContext = (T)Activator.CreateInstance(typeof(T), builder.Options);

            return dbContext;
        }
    }
}

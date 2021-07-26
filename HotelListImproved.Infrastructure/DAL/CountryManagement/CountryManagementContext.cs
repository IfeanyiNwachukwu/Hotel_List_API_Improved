using HotelListImproved.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelListImproved.Infrastructure.DAL.CountryManagement
{
    public class CountryManagementContext : DbContext
    {
        public CountryManagementContext(DbContextOptions<CountryManagementContext> options
            ) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
       
    }
}

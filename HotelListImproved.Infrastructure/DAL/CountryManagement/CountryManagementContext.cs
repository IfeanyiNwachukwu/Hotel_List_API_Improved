using HotelListImproved.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelListImproved.Infrastructure.DAL.CountryManagement
{
    public class CountryManagementContext : BaseContext<CountryManagementContext>
    {

        public CountryManagementContext(DbContextOptions<CountryManagementContext> options
         ) : base(options)
        {

        }
        public DbSet<Country> Country { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

    }
}

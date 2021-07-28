using HotelListImproved.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelListImproved.Infrastructure.DAL.HotelManagement
{
    public class HotelManagementContext : BaseContext<HotelManagementContext>
    {
        public HotelManagementContext(DbContextOptions<HotelManagementContext> options
          ) : base(options)
        {

        }

       

        public  DbSet<Hotel> Hotel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

    }
}

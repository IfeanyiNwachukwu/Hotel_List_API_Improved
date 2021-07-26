using HotelListImproved.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelListImproved.Infrastructure.DAL.HotelManagement
{
    public class HotelManagementContext : DbContext
    {
        public HotelManagementContext(DbContextOptions<HotelManagementContext> options):base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }

        
    }
}

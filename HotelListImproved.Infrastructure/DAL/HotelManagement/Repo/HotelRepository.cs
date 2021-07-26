using HotelListImproved.Core.Entities;
using HotelListImproved.Core.Interface.HotelManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL.HotelManagement.Repo
{
    public class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(HotelManagementContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<Hotel> GetCountry(int id)
        {
            return await GetWhere(k => k.Id == id).SingleOrDefaultAsync();
        }

        // To be mapped in the controller
        public async Task<List<Hotel>> GetCountries()
        {
            var countries = await GetAll().ToListAsync();

            return countries;
        }

    }
}

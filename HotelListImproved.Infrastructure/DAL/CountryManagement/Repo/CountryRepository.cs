
using HotelListImproved.Core.DTOs.ReadOnly;
using HotelListImproved.Core.Entities;
using HotelListImproved.Core.Interface.CountryManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL.CountryManagement.Repo
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(CountryManagementContext _dbContext):base(_dbContext)
        {

        }

        public async Task<Country> GetCountry(int id)
        {
            return await GetWhere(k => k.Id == id).SingleOrDefaultAsync();
        }

        // To be mapped in the controller
        public async Task<List<Country>> GetCountries()
        {
            var countries = await GetAll().ToListAsync();

           return countries;
        }


    }
}

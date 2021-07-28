using HotelListImproved.Core.Interface.CountryManagement;
using HotelListImproved.Infrastructure.DAL.CountryManagement.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL.CountryManagement
{
    public class CountryManagementUOW : IUnitOfWork<CountryManagementContext>
    {
        private readonly CountryManagementContext _dbContext;

        public ICountryRepository CountryManagement { get; set; }

        public CountryManagementUOW(CountryManagementContext dbContext)
        {
            if(dbContext == null)
            {
                throw new ArgumentNullException("dbContext", "Null dbContext passed.");
                
            }
            _dbContext = dbContext;
            CountryManagement = new CountryRepository(_dbContext); 
        }
        //public CountryManagementUOW()
        //{
        //    _dbContext = new CountryManagementContext();
        //    CountryManagement = new CountryRepository(_dbContext);


        //}

        public CountryManagementContext DBContext
        {
            get { return _dbContext; }
        }
      

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

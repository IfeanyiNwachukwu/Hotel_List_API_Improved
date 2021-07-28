using HotelListImproved.Core.Interface.HotelManagement;
using HotelListImproved.Infrastructure.DAL.HotelManagement.Repo;
using System;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL.HotelManagement
{
    public class HotelManagementUOW /*: BaseContext<HotelManagementContext>,  IUnitOfWork<HotelManagementContext>*/
    {
        private readonly HotelManagementContext _dbContext;

        public IHotelRepository HotelManagement { get; set; }

        //public HotelManagementUOW(HotelManagementContext dbContext)
        //{
        //    if (dbContext == null)
        //    {
        //        throw new ArgumentNullException("dbContext", "Null dbContext passed.");

        //    }
        //    _dbContext = dbContext;
        //    HotelManagement = new HotelRepository(_dbContext);
        //}

     

        //public HotelManagementUOW()
        //{
        //    _dbContext = new HotelManagementContext();
        //    HotelManagement = new HotelRepository(_dbContext);


        //}

        public HotelManagementContext DBContext
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

        public  void Dispose()
        {
            _dbContext.Dispose();
        }

    }
}

using HotelListImproved.Core.Entities;
using System.Threading.Tasks;

namespace HotelListImproved.Core.Interface.CountryManagement
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        Task<Country> GetCountry(int id);
    }
}

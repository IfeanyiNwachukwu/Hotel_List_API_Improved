using AutoMapper;
using HotelListImproved.Core.DTOs.ReadOnly;
using HotelListImproved.Core.Entities;

namespace HotelListImproved.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
        }
    }
}

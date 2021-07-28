using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Core.DTOs.ReadOnly
{
    public class HotelDTO
    {


        public string Name { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }

        public int CountryId { get; set; }
        public CountryMapDTO CountryInfo { get; set; }

    }
}

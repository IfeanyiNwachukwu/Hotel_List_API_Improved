using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Core.Entities
{
    public class Country
    {
        public Country()
        {
            Hotel = new HashSet<Hotel>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(4)]
        public string ShortName { get; set; }
       
        public virtual ICollection<Hotel> Hotel { get; set; }


        



        //public virtual IList<Hotel> Hotels { get; set; }
    }
}

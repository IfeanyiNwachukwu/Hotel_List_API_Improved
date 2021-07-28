using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {

        public BaseContext(DbContextOptions options
            ) : base(options)
        {

        }

    }
}

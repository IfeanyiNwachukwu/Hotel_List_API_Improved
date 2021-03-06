using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL
{
    public interface IUnitOfWork<out TContext> : IDisposable where TContext: DbContext
    {
        int Complete();
        Task<int> CompleteAsync();
        TContext DBContext { get; }


    }
}

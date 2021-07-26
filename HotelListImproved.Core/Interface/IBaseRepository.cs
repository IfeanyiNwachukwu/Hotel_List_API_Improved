using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelListImproved.Core.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAllWithNoTracking();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> wherePredicate); //This allows the use of lambda expression as expected query argument
        IQueryable<T> GetWhereWithNoTracking(Expression<Func<T, bool>> wherePredicate);
        void Override(T destination, T source);
        bool ExistsWhere(Expression<Func<T, bool>> wherePredicate);
        bool ExistWhereWithNoTracking(Expression<Func<T, bool>> wherePredicate);
        Task<bool> ExistsWhereAsync(Expression<Func<T, bool>> wherePredicate);
        Task<bool> ExistWhereWithNoTrackingAsync(Expression<Func<T, bool>> wherePredicate);
        void Add(T entity);
        void AddRange(IList<T> entities);
        void AddGraph(T entity);
        void Update(T entity);
        void UpdateGraph(T entity);
        void Remove(T entity);
        void RemoveRange(IList<T> entities);
        IEnumerable<T> GetWithRawSql(string query, params object[] parameters);
    
    
    
    
    
    }
}

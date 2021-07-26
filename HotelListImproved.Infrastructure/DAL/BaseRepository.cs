using HotelListImproved.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListImproved.Infrastructure.DAL
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext dbContext;

        public BaseRepository(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public void Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public void AddGraph(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public void AddRange(IList<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
        }

        public bool ExistsWhere(Expression<Func<T, bool>> wherePredicate)
        {
            return GetAll()
                .Where(wherePredicate)
                .Any();
        }

        public async Task<bool> ExistsWhereAsync(Expression<Func<T, bool>> wherePredicate)
        {
            return await GetAll()
                .Where(wherePredicate)
                .AnyAsync();
        }

        public bool ExistWhereWithNoTracking(Expression<Func<T, bool>> wherePredicate)
        {
            return GetAllWithNoTracking()
                .Where(wherePredicate)
                .Any();
        }

        public async Task<bool> ExistWhereWithNoTrackingAsync(System.Linq.Expressions.Expression<Func<T, bool>> wherePredicate)
        {
            return await GetAllWithNoTracking()
                .Where(wherePredicate)
                .AnyAsync();
        }

        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public IQueryable<T> GetAllWithNoTracking()
        {
            return dbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> wherePredicate)
        {
            return GetAll()
                .Where(wherePredicate);
        }

        public IQueryable<T> GetWhereWithNoTracking(Expression<Func<T, bool>> wherePredicate)
        {
            return GetAllWithNoTracking()
                .Where(wherePredicate);
        }

        public IEnumerable<T> GetWithRawSql(string query, params object[] parameters)
        {
           
            throw new NotImplementedException();
        }

        public void Override(T destination, T source)
        {
            dbContext.Entry(destination).CurrentValues.SetValues(source);
        }

        public void Remove(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IList<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateGraph(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}

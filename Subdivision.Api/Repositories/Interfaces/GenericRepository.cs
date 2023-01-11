using Microsoft.EntityFrameworkCore;
using Subdivision.Api.Models;
using System.Linq.Expressions;

namespace Subdivision.Api.Repositories.Interfaces
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SubdivisionDbContext dbContext; 
        private DbSet<T>  dbSet => dbContext.Set<T>();
        public GenericRepository(SubdivisionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public void Update(T entity)
        {
          
        }
        public T GetById(Expression<Func<T, bool>> predicat)
        {
            return dbSet.Where(predicat).First();
        }
    }
}

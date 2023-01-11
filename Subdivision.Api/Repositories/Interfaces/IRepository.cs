using System.Linq.Expressions;

namespace Subdivision.Api.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        void Add(T entity); 
        void Update(T entity);
        T GetById(Expression<Func<T,bool>> predicat);
    }
}

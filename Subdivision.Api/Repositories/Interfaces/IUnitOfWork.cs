using Subdivision.Api.Models;

namespace Subdivision.Api.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Country> CountryRepository{ get; set; }
        void Commit();
        void RejetChanges();
        void Dispose();
    }
}

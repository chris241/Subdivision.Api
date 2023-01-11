using Subdivision.Api.Models;
using Subdivision.Api.Repositories.Interfaces;

namespace Subdivision.Api.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SubdivisionDbContext dbContext;
        public IRepository<Country> CountryRepository { get =>  new GenericRepository<Country>(dbContext); set => throw new NotImplementedException(); }
        
        public UnitOfWork(SubdivisionDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }
        public void Commit()
        {
            this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }

        public void RejetChanges()
        {
            throw new NotImplementedException();
        }
    }
}



using Microsoft.EntityFrameworkCore;

namespace Subdivision.Api.Models
{
    public class SubdivisionDbContext: DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Village> Villages { get; set; }
        public SubdivisionDbContext(DbContextOptions<SubdivisionDbContext> options) :base(options)
        {

        }

    }
}

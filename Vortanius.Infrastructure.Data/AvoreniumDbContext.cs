using Vortanius.Core.Domain.Entities.Data.Dbo;
using Vortanius.Infrastructure.Data.EntityMaps.Dbo;
using Microsoft.EntityFrameworkCore;

namespace Vortanius.Infrastructure.Data
{
    public class VortaniusDbContext : DbContext
    {
        public VortaniusDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IssueMap());
        }
    }
}
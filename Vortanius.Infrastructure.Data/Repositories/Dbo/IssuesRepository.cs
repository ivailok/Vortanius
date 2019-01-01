using Vortanius.Core.Domain.Entities.Data.Dbo;
using Vortanius.Core.Interfaces.Data.Repositories.Dbo;

namespace Vortanius.Infrastructure.Data.Repositories.Dbo
{
    public class IssuesRepository : Repository<Issue, int>, IIssuesRepository
    {
        public IssuesRepository(VortaniusDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
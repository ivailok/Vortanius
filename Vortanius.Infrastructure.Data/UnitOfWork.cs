using System;
using System.Threading.Tasks;
using Vortanius.Core.Interfaces.Data;

namespace Vortanius.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VortaniusDbContext dbContext;

        public UnitOfWork(
            VortaniusDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CompleteAsync()
        {
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Vortanius.Core.Domain.Entities.Data.Base;

namespace Vortanius.Core.Interfaces.Data.Repositories
{
    public interface IRepository<TEntity, T>
        where TEntity : class, IEntity<T>
    {
        Task<TEntity> GetAsync(int id);

        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, bool shouldTrack = true);

        void Add(TEntity entity);

        void AddRange(List<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(List<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(List<TEntity> entities);
    }
}
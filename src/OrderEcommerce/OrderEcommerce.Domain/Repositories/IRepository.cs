using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace OrderEcommerce.Domain.Repositories
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity Get(Guid id);
        IEnumerable<Entity> Get(Func<Entity, bool> predicateToUseInGet, int skip = 0, int offset = 0);
        int Count(Func<Entity, bool> predicateToUseInCount = null);
        Entity Remove(Entity entityToRemove);
        bool Update(Entity entityToUpdate);
        Entity Create(Entity entityToCreate);

        Task<Entity> GetAsync(Guid id);
        Task<Entity> GetAsync(Guid id, CancellationToken cancellationToken);
        
        Task<int> CountAsync(Expression<Func<Entity, bool>> predicateToUseInCount = null);
        Task<int> CountAsync(Expression<Func<Entity, bool>> predicateToUseInCount, CancellationToken cancellationToken);
        Task<int> CountAsync(CancellationToken cancellationToken);         
    }
}

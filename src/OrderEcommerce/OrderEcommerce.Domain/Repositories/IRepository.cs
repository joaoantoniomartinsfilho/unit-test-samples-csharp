using System;
using System.Collections.Generic;

namespace OrderEcommerce.Domain.Repositories
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity Get(Guid id);
        IEnumerable<Entity> Get(Func<Entity, bool> predicateToUseInGet, int skip = 0, int offset = 0);
        int Count(Func<Entity, bool> predicateToUseInCount = null);
        bool Remove(Entity entityToRemove);
        Entity Update(Entity entityToUpdate);
        Entity Create(Entity entityToCreate);
    }
}

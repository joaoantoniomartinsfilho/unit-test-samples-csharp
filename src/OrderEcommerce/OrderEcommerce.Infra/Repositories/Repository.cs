﻿using OrderEcommerce.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace OrderEcommerce.Infra.Repositories
{
    public abstract class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        protected DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public int Count(Func<Entity, bool> predicateToUseInCount = null)
         => predicateToUseInCount == null ?
                _context.Set<Entity>().Count() :
                _context.Set<Entity>().Count(predicateToUseInCount);        

        public Task<int> CountAsync(Expression<Func<Entity, bool>> predicateToUseInCount = null)
         => predicateToUseInCount == null ? 
                _context.Set<Entity>().CountAsync() :
                _context.Set<Entity>().CountAsync(predicateToUseInCount);        

        public Task<int> CountAsync(Expression<Func<Entity, bool>> predicateToUseInCount, CancellationToken cancellationToken)
            => _context.Set<Entity>().CountAsync(predicateToUseInCount, cancellationToken);

        public Task<int> CountAsync(CancellationToken cancellationToken)
            => _context.Set<Entity>().CountAsync(cancellationToken);

        public Entity Create(Entity entityToCreate)
            => _context.Set<Entity>().Add(entityToCreate);

        public Entity Get(Guid id)
        => _context.Set<Entity>().Find(id);

        public IEnumerable<Entity> Get(Func<Entity, bool> predicateToUseInGet, int skip = default, int offset = default)
        {
            var query = _context.Set<Entity>().Where(predicateToUseInGet).AsQueryable();

            if (skip > 0)
                query = query.Skip(skip);

            if(offset > 0)
                query = query.Take(offset);

            return query;
        }

        public Task<Entity> GetAsync(Guid id)
            => _context.Set<Entity>().FindAsync(id);

        public Task<Entity> GetAsync(Guid id, CancellationToken cancellationToken)
            => _context.Set<Entity>().FindAsync(cancellationToken, id);

        public Task<IEnumerable<Entity>> GetAsync(Func<Entity, bool> predicateToUseInGet, int skip = 0, int offset = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity>> GetAsync(CancellationToken cancellationToken, Func<Entity, bool> predicateToUseInGet, int skip = 0, int offset = 0)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Entity entityToRemove)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> RemoveAsync(Entity entityToRemove)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> RemoveAsync(Entity entityToRemove, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Entity Update(Entity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> UpdateAsync(Entity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> UpdateAsync(Entity entityToUpdate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Entity IRepository<Entity>.Remove(Entity entityToRemove)
        {
            throw new NotImplementedException();
        }
    }
}

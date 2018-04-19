using System;
using System.Collections.Generic;
using System.Linq;

namespace _DataAccessLayer.Repositories.Abstract
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity Get(Func<TEntity, bool> criteria)
        {
            var result = default(TEntity);
            using (var context = new CrowdNetDBContext())
            {
                result = context.Set<TEntity>().FirstOrDefault(criteria);
            }
            return result;
        }

        public IEnumerable<TEntity> GetWhere(Func<TEntity, bool> criteria)
        {
            var result = default(IEnumerable<TEntity>);
            using (var context = new CrowdNetDBContext())
            {
                result = context.Set<TEntity>().Where(criteria);
            }
            return result;
        }

        public void Delete(TEntity model)
        {
        }

        public TEntity Modify(TEntity model)
        {
            return default(TEntity);
        }

        public TEntity Add(TEntity model)
        {
            return default(TEntity);
        }
    }
}
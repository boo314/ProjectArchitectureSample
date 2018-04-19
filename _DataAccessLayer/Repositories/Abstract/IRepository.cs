using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataAccessLayer.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Func<TEntity, bool> criteria);
        IEnumerable<TEntity> GetWhere(Func<TEntity, bool> criteria);
        void Delete(TEntity model);
        TEntity Modify(TEntity model);
        TEntity Add(TEntity model);
    }
}

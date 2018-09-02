using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.Repositories.Interfaces
{
    interface IRepository<TKey, TEntity>
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        TEntity Find(TKey key);
        IReadOnlyList<TEntity> All();
    }
}

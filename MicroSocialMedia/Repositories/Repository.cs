using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroSocialMedia.Data;
using MicroSocialMedia.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MicroSocialMedia.Repositories
{
    public class Repository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet { get; set; }
        private AppDbContext _appDbContext { get; set; }

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            DbSet = _appDbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public IReadOnlyList<TEntity> All()
        {
            return DbSet.ToList();
        }

        public TEntity Find(TKey key)
        {
            return DbSet.Find(key);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}

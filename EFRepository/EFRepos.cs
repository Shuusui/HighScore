using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace EFRepository
{
    class EFRepos<TEntity> : IRepository<TEntity> where TEntity :class
     {
        protected HighScoreDbContext ctx;
        public EFRepos(HighScoreDbContext ctx) { this.ctx = ctx; }

        public TEntity Create(TEntity entity)
        {
            entity = ctx.Set<TEntity>().Add(entity);
            ctx.SaveChanges();
            return entity;
        }
        
        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return ctx.Set<TEntity>();            
        }

        TEntity IRepository<TEntity>.GetById(int id)
        {
            return ctx.Set<TEntity>().Find(id);
        }
    }
}

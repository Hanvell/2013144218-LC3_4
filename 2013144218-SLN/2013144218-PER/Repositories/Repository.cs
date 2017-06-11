using _2013144218_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace _2013144218_PER.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
         
    {
        private readonly _2013144218_SLNDbContext _Context;

        public Repository(_2013144218_SLNDbContext context)
        {
            _Context = context;
        }
        public void Delete(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }

       public TEntity Get(int? Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }

        public IEnumerable <TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Context.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
        }


        public void AddRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().AddRange(entities);
        }

       
    }
}

using ReusableGenericRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedGenericRepository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IEnumerable<TEntity> results = _dbSet.AsNoTracking().Where(predicate).ToList();
            return results;
        }

        public TEntity FindByKey(int id)
        {
            //AsNoTracking works on a dbQuery not a db set.  It doesn't add data to the cache.


            //-note dbSet.Find() checks the cache before it checks the database so we don't use it to save a query to the cache
            // build or own lamda that assumes the id is the Name of Entity + "Id"

            Expression<Func<TEntity, bool>> lambda = Utilities.BuildLambdaForFindByKey<TEntity>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
           
        }

        public void Delete(int id)
        {

        }

        public IEnumerable<TEntity> AllInclude(params Expression<Func<TEntity,object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<TEntity> FindByInclude(Expression<Func<TEntity,bool>> predicate,
            params Expression<Func<TEntity,object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<TEntity> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate(queryable, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}

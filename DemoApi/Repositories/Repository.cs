using Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DemoApi
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();

        }

        public virtual IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }

        public virtual async Task<List<TEntity>> GetListAsync()
        {
            try
            {
                return await _context.Set<TEntity>().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _context.Set<TEntity>().Where(predicate).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<TEntity> GetAsync(TKey id, params Expression<Func<TEntity, object>>[] includes)
        {
            try
            {
                IQueryable<TEntity> query = _context.Set<TEntity>().Where(e => e.Id.Equals(id));
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
                return await query.FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            // Apply includes for eager loading
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            // Apply predicate for filtering
            query = query.Where(predicate);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<IEnumerable<TEntity>> InsertRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<IEnumerable<TEntity>> UpdateMultiAsync(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }
        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            //if (entity is FullAuditedAggregateRoot<TKey> fullAuditedEntity)
            //{
            //    fullAuditedEntity.IsDeleted = true;
            //    fullAuditedEntity.DeletionTime = DateTime.UtcNow;
            //    fullAuditedEntity.DeleterId = UserHelper.GetCurrentUserId();

            //    _context.Update(fullAuditedEntity);
            //}
            //else
            //{
                _context.Set<TEntity>().Remove(entity);
            //}

            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<IEnumerable<TEntity>> DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                //if (entity is FullAuditedAggregateRoot<TKey> fullAuditedEntity)
                //{
                //    fullAuditedEntity.IsDeleted = true;
                //    fullAuditedEntity.DeletionTime = DateTime.UtcNow;
                //    fullAuditedEntity.DeleterId = UserHelper.GetCurrentUserId();

                //    _context.Update(fullAuditedEntity);
                //}
                //else
                //{
                    _context.Set<TEntity>().Remove(entity);
                //}
            }

            await _context.SaveChangesAsync();
            return entities;
        }

        public async Task<long> GetCountAsync()
        {
            // Check if TEntity has IsDeleted property
            var property = typeof(TEntity).GetProperty("IsDeleted");

            if (property != null)
            {
                var parameter = Expression.Parameter(typeof(TEntity), "e");
                var isDeletedProperty = Expression.Property(parameter, property);
                var falseConstant = Expression.Constant(false);
                var notDeleted = Expression.Equal(isDeletedProperty, falseConstant);
                var predicate = Expression.Lambda<Func<TEntity, bool>>(notDeleted, parameter);

                return await _context.Set<TEntity>().CountAsync(predicate);
            }
            else
            {
                return await _context.Set<TEntity>().CountAsync();
            }
        }
        public async Task<long> GetCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            // Check if TEntity has IsDeleted property
            var parameter = Expression.Parameter(typeof(TEntity), "e");
            var property = typeof(TEntity).GetProperty("IsDeleted");

            if (property != null)
            {
                var isDeletedProperty = Expression.Property(parameter, property);
                var falseConstant = Expression.Constant(false);
                var notDeleted = Expression.Equal(isDeletedProperty, falseConstant);

                var combinedPredicate = Expression.Lambda<Func<TEntity, bool>>(
                    Expression.AndAlso(
                        Expression.Invoke(predicate, parameter),
                        notDeleted
                    ),
                    parameter
                );

                return await _context.Set<TEntity>().CountAsync(combinedPredicate);
            }
            else
            {
                return await _context.Set<TEntity>().CountAsync(predicate);
            }
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

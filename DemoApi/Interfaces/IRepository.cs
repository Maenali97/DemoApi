using System.Linq.Expressions;

namespace Domain
{
	public interface IRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        IQueryable<TEntity> Query();
        Task<List<TEntity>> GetListAsync();
		Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> GetAsync(TKey id, params Expression<Func<TEntity, object>>[] includes);
		Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity> InsertAsync(TEntity entity);
		Task<IEnumerable<TEntity>> InsertRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
		Task<IEnumerable<TEntity>> UpdateMultiAsync(IEnumerable<TEntity> entities);
        Task<TEntity> DeleteAsync(TEntity entity);
        Task<IEnumerable<TEntity>> DeleteRangeAsync(IEnumerable<TEntity> entities);
        Task<long> GetCountAsync();
		Task<long> GetCountAsync(Expression<Func<TEntity, bool>> predicate);
		Task SaveChangesAsync();

    }
}

using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BackendFinal.Db.Models.Contracts;

namespace BackendFinal.Db.Repositories.Contracts
{
	public interface IDbRepository<TEntity>
		where TEntity : class, IIdentifiable
    {
		Task<TEntity[]> FindAsync(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
		Task AddAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
	}
}

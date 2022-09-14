using Millitary.API.Models.Local;
using System.Linq.Expressions;

namespace Millitary.API.Models.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<Result<T>> FindAsync(int id);
        Task<Result<T>> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter);
        Task<Result<IEnumerable<T>>> GetAllAsync();
        Task<Result<T>> AddAsync(T entity);
        Task<Result<bool>> DeleteAsync(T entity);
        Task<Result<T>> UpdateAsync(T entity);
    }
}
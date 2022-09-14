using Microsoft.EntityFrameworkCore;
using Millitary.API.Models.Data;
using Millitary.API.Models.Local;
using Millitary.API.Models.Repository.IRepository;
using System.Linq.Expressions;

namespace Millitary.API.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        internal DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async virtual Task<Result<T>> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return new Result<T>(entity);
        }

        public Task<Result<bool>> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.FromResult(new Result<bool>(true));
        }

        public async Task<Result<T>> FindAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return new Result<T>(entity);
        }

        public async Task<Result<IEnumerable<T>>> GetAllAsync()
        {
            var entities = await _dbSet.ToListAsync();
            return new Result<IEnumerable<T>>(entities);
        }

        public async Task<Result<T>> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            var entity = await _dbSet.Where(filter).FirstOrDefaultAsync();
            
            return new Result<T>(entity);
        }

        public Task<Result<T>> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
} 
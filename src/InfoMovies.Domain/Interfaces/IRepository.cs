using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfoMovies.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<T> GetByIdAsync(int id);
        void AddAsync(T obj);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        void Update(T obj);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllWithIncludingAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        void Delete(T entity);
        Task<int> CountAsync();
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}

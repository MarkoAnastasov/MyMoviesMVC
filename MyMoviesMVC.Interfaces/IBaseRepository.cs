using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetFirstWhereAsync(Expression<Func<T, bool>> predicate);

        Task<List<T>> GetAllWhereAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        
        void Update(T entity);

        void Remove(T entity);

        Task SaveEntitiesAsync();
    }
}

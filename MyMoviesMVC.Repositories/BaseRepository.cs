using Microsoft.EntityFrameworkCore;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyMoviesMVC.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly mymoviesmvcContext _context;

        public BaseRepository(mymoviesmvcContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetFirstWhereAsync(Expression<Func<T,bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetAllWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
             _context.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task SaveEntitiesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

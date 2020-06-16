using MyMoviesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IUserMovieRepository : IBaseRepository<UserMovie>
    {
        Task<List<UserMovie>> GetAllWhereMovieIncludedAsync(Expression<Func<UserMovie, bool>> predicate);
    }
}

using MyMoviesMVC.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
        Task<Movie> GetFirstWhereCommentsIncludedAsync(Expression<Func<Movie, bool>> predicate);
    }
}

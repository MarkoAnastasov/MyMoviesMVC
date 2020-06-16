using MyMoviesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IMovieCommentRepository : IBaseRepository<MovieComment>
    {
        Task<List<MovieComment>> GetAllWhereUserIncludedAsync(Expression<Func<MovieComment, bool>> predicate);
    }
}

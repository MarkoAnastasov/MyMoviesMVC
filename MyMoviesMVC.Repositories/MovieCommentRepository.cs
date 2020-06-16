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
    public class MovieCommentRepository : BaseRepository<MovieComment>, IMovieCommentRepository
    {
        private readonly mymoviesmvcContext _context;

        public MovieCommentRepository(mymoviesmvcContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<MovieComment>> GetAllWhereUserIncludedAsync(Expression<Func<MovieComment, bool>> predicate)
        {
            return _context.MovieComments.Include(x => x.User).Where(predicate).ToListAsync();
        }
    }
}

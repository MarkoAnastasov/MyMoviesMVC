using Microsoft.EntityFrameworkCore;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyMoviesMVC.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly mymoviesmvcContext _context;

        public MovieRepository(mymoviesmvcContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetFirstWhereCommentsIncludedAsync(Expression<Func<Movie,bool>> predicate)
        {
            return await _context.Movies
                .Include(x => x.MovieComments)
                    .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(predicate);
        }
    }
}

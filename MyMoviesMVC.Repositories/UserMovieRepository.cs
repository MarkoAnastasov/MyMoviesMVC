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
    public class UserMovieRepository : BaseRepository<UserMovie>, IUserMovieRepository
    {
        private readonly mymoviesmvcContext _context;

        public UserMovieRepository(mymoviesmvcContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<UserMovie>> GetAllWhereMovieIncludedAsync(Expression<Func<UserMovie,bool>> predicate)
        {
            return await _context.UserMovies.Include(x => x.Movie).Where(predicate).ToListAsync();
        }
    }
}

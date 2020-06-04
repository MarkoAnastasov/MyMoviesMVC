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
    public class UserCollectionsRepository : BaseRepository<User> , IUserCollectionsRepository
    {
        private readonly mymoviesmvcContext _context;

        public UserCollectionsRepository(mymoviesmvcContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdIncludedMoviesAsync(int id)
        {
            return await _context.Users.Include(x => x.UserMovies)
                                            .ThenInclude(x => x.Movie)
                                       .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

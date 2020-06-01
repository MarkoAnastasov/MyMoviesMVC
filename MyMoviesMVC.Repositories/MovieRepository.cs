using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;

namespace MyMoviesMVC.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(mymoviesmvcContext context) : base(context)
        {

        }
    }
}

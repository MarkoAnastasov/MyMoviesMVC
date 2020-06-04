using MyMoviesMVC.Models;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IUserCollectionsRepository : IBaseRepository<User>
    {
        Task<User> GetUserByIdIncludedMoviesAsync(int id);
    }
}

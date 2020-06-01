using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IMovieService
    {
        Task<List<MovieMainDTO>> GetAllMovies();

        Task<MovieMainDTO> GetTargetMovie(int id);

        Task<List<MovieMainDTO>> SearchMoviesByTitle(string title);

        Task AddMovie(AddMovieDTO movieDTO);
    }
}

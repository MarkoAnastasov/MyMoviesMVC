using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IMovieService
    {
        Task<List<MovieMainDTO>> GetAllMoviesAsync();

        Task<MovieMainDTO> GetTargetMovieAsync(int id);

        Task<List<MovieMainDTO>> SearchMoviesByTitleAsync(string title);

        Task AddMovieAsync(AddMovieDTO movieDTO);
    }
}

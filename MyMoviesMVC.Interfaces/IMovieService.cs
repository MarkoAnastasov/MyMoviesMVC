using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IMovieService
    {
        Task<MovieMainDTO> GetTargetMovieAsync(int id);

        Task<List<MovieMainDTO>> SearchMoviesByTitleAsync(string title);

        Task AddMovieAsync(AddMovieDTO movieDTO);

        Task<EditMovieDTO> FindMovieAndConvertToEdit(int id);

        Task EditMovieAsync(int id,EditMovieDTO editMovieDTO);

        Task RemoveMovieAsync(int id);
    }
}

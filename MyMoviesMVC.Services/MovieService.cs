using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Common.Helpers.Converters;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMoviesMVC.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<MovieMainDTO> GetTargetMovieAsync(int id)
        {
            var targetMovie = await GetMovieByIdAndCheckNullAsync(id);

            return ModelToDTO.MovieToMovieMainDTO(targetMovie);
        }

        public async Task<List<MovieMainDTO>> SearchMoviesByTitleAsync(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                title = "";
            }

            var targetMovies = await _movieRepository.GetAllWhereAsync(x => x.Title.ToUpper().Contains(title.Trim().ToUpper()));

            if(targetMovies == null)
            {
                return new List<MovieMainDTO>();
            }

            return targetMovies.Select(x => ModelToDTO.MovieToMovieMainDTO(x)).ToList();
        }

        public async Task AddMovieAsync(AddMovieDTO addMovieDTO)
        {
            var existingMovie = await _movieRepository.GetFirstWhereAsync(x => x.Title.ToUpper() == addMovieDTO.Title.Trim().ToUpper());

            if(existingMovie != null)
            {
                throw new FlowException("Movie already exists!");
            }

            _movieRepository.Add(await DTOToModel.AddMovieDTOToMovie(addMovieDTO));
            await _movieRepository.SaveEntitiesAsync();
        }

        public async Task<EditMovieDTO> FindMovieAndConvertToEdit(int id)
        {
            var targetMovie = await GetMovieByIdAndCheckNullAsync(id);

            return ModelToDTO.MovieToEditMovieDTO(targetMovie);
        }

        public async Task EditMovieAsync(int id,EditMovieDTO editMovieDTO)
        {
            var targetMovie = await GetMovieByIdAndCheckNullAsync(id);

            _movieRepository.Update(await DTOToModel.EditMovieDTOToMovie(editMovieDTO, targetMovie));
            await _movieRepository.SaveEntitiesAsync();
        }

        public async Task RemoveMovieAsync(int id)
        {
            var targetMovie = await GetMovieByIdAndCheckNullAsync(id);

            _movieRepository.Remove(targetMovie);
            await _movieRepository.SaveEntitiesAsync();
        }

        private async Task<Movie> GetMovieByIdAndCheckNullAsync(int id)
        {
            var targetMovie = await _movieRepository.GetFirstWhereAsync(x => x.Id == id);

            if (targetMovie == null)
            {
                throw new FlowException("Movie not found!");
            }

            return targetMovie;
        }
    }
}

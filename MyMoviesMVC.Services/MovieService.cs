using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Common.Helpers.Converters;
using MyMoviesMVC.Interfaces;
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

        public async Task<List<MovieMainDTO>> GetAllMovies()
        {
            var moviesList = await _movieRepository.GetAllAsync();

            return moviesList.Select(x => ModelToDTO.MovieToMovieMainDTO(x)).ToList();
        }

        public async Task<MovieMainDTO> GetTargetMovie(int id)
        {
            var targetMovie = await _movieRepository.GetFirstWhereAsync(x => x.Id == id);

            if(targetMovie == null)
            {
                throw new FlowException();
            }

            return ModelToDTO.MovieToMovieMainDTO(targetMovie);
        }

        public async Task<List<MovieMainDTO>> SearchMoviesByTitle(string title)
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

        public async Task AddMovie(AddMovieDTO movieDTO)
        {
            var existingMovie = await _movieRepository.GetFirstWhereAsync(x => x.Title.ToUpper() == movieDTO.Title.Trim().ToUpper());

            if(existingMovie != null)
            {
                throw new FlowException("Movie already exists!");
            }

            _movieRepository.Add(await DTOToModel.AddMovieDTOToMovie(movieDTO));
            await _movieRepository.SaveEntitiesAsync();
        }
    }
}

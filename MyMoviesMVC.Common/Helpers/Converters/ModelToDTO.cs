using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using MyMoviesMVC.ModelsDTO.User;
using MyMoviesMVC.ModelsDTO.UserMovies;
using System;

namespace MyMoviesMVC.Common.Helpers.Converters
{
    public static class ModelToDTO
    {
        public static MovieMainDTO MovieToMovieMainDTO(Movie movie)
        {
            return new MovieMainDTO()
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                Description = movie.Description,
                Cover = Convert.ToBase64String(movie.Cover)
            };
        }

        public static EditMovieDTO MovieToEditMovieDTO(Movie movie)
        {
            return new EditMovieDTO()
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                Description = movie.Description
            };
        }

        public static UserOverviewDTO UserToUserMainDTO(User user)
        {
            return new UserOverviewDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ProfilePicture = Convert.ToBase64String(user.ProfilePicture)
            };
        }

        public static UserMovieDTO UserMovieToDTO(UserMovies userMovie)
        {
            return new UserMovieDTO()
            {
                Id = userMovie.Movie.Id,
                Title = userMovie.Movie.Title,
                Cover = Convert.ToBase64String(userMovie.Movie.Cover),
                Description = userMovie.Movie.Description,
                IsFavourite = userMovie.IsFavourite,
                IsWatched = userMovie.IsWatched
            };
        }
    }
}

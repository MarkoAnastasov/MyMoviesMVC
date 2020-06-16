using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using MyMoviesMVC.ModelsDTO.MovieComment;
using MyMoviesMVC.ModelsDTO.User;
using MyMoviesMVC.ModelsDTO.UserMovie;
using System;
using System.Linq;

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
                Views = movie.Views,
                Description = movie.Description,
                Cover = Convert.ToBase64String(movie.Cover),
                Comments = movie.MovieComments.Select(x => MovieCommentToMainDTO(x)).ToList()
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

        public static SearchMovieDTO MovieToSearchMovieDTO(Movie movie)
        {
            return new SearchMovieDTO()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Cover = Convert.ToBase64String(movie.Cover)
            };
        }

        public static UserOverviewDTO UserToUserMainDTO(User user)
        {
            return new UserOverviewDTO()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ProfilePicture = Convert.ToBase64String(user.ProfilePicture)
            };
        }

        public static UserMovieDTO UserMovieToDTO(UserMovie userMovie)
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

        public static MovieCommentMainDTO MovieCommentToMainDTO(MovieComment movieComment)
        {
            return new MovieCommentMainDTO()
            {
                Id = movieComment.Id,
                Comment = movieComment.Comment,
                User = UserToUserMainDTO(movieComment.User)
            };
        }

        public static ApprovalOverviewDTO MovieCommentToApprovalDTO(MovieComment movieComment)
        {
            return new ApprovalOverviewDTO()
            {
                Id = movieComment.Id,
                UserId = movieComment.UserId,
                UserFullName = movieComment.User.FirstName + ' ' + movieComment.User.LastName,
                Comment = movieComment.Comment
            };
        }
    }
}

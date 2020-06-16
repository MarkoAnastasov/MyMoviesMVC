using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Account;
using MyMoviesMVC.ModelsDTO.Movie;
using MyMoviesMVC.ModelsDTO.MovieComment;
using System.Threading.Tasks;

namespace MyMoviesMVC.Common.Helpers.Converters
{
    public static class DTOToModel
    {
        public static async Task<User> RegisterDTOToUser(RegisterDTO registerDTO)
        {
            return new User()
            {
                FirstName = registerDTO.FirstName.Trim(),
                LastName = registerDTO.LastName.Trim(),
                Email = registerDTO.Email.Trim(),
                ProfilePicture = await FileToByteArray.ImageToByteArray(registerDTO.ProfilePicture),
                UserName = registerDTO.Email + RandomString.GenerateRandomString(4)
            };
        }

        public static async Task<Movie> AddMovieDTOToMovie(AddMovieDTO addMovieDTO)
        {
            return new Movie()
            {
                Title = addMovieDTO.Title.Trim(),
                Description = addMovieDTO.Description.Trim(),
                Genre = addMovieDTO.Genre,
                Cover = await FileToByteArray.ImageToByteArray(addMovieDTO.Cover)
            };
        }

        public static async Task<Movie> EditMovieDTOToMovie(EditMovieDTO addMovieDTO, Movie movie)
        {
            movie.Title = addMovieDTO.Title.Trim();
            movie.Description = addMovieDTO.Description.Trim();
            movie.Genre = addMovieDTO.Genre;

            if (addMovieDTO.Cover != null)
            {
                movie.Cover = await FileToByteArray.ImageToByteArray(addMovieDTO.Cover);

            }

            return movie;
        }

        public static async Task<User> UpdatePersonalDTOToUser(UpdatePersonalDTO personalDTO, User user)
        {
            user.FirstName = personalDTO.FirstName;
            user.LastName = personalDTO.LastName;

            if(personalDTO.ProfilePicture != null)
            {
                user.ProfilePicture = await FileToByteArray.ImageToByteArray(personalDTO.ProfilePicture);
            }

            return user;
        }

        public static UserMovie AddUserMovieToUserMovie(int movieId, int userId)
        {
            return new UserMovie()
            {
                UserId = userId,
                MovieId = movieId,
                IsFavourite = false,
                IsWatched = false
            };
        }

        public static MovieComment AddMovieCommentDTOToModel(AddMovieCommentDTO addMovieCommentDTO, int userId)
        {
            return new MovieComment()
            {
                Comment = addMovieCommentDTO.Comment,
                UserId = userId,
                MovieId = addMovieCommentDTO.MovieId
            };
        }
    }
}

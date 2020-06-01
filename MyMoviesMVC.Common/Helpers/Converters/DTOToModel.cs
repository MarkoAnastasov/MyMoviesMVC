using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Account;
using MyMoviesMVC.ModelsDTO.Movie;
using System.Threading.Tasks;

namespace MyMoviesMVC.Common.Helpers.Converters
{
    public static class DTOToModel
    {
        public static async Task<User> RegisterDTOToUser(RegisterDTO registerDTO)
        {
            var newUser = new User()
            {
                FirstName = registerDTO.FirstName.Trim(),
                LastName = registerDTO.LastName.Trim(),
                Email = registerDTO.Email.Trim(),
                ProfilePicture = await FileToByteArray.ImageToByteArray(registerDTO.ProfilePicture),
                UserName = registerDTO.Email + RandomString.GenerateRandomString(4)
            };

            return newUser;
        }

        public static async Task<Movie> AddMovieDTOToMovie(AddMovieDTO movieDTO)
        {
            var movie = new Movie()
            {
                Title = movieDTO.Title.Trim(),
                Description = movieDTO.Description.Trim(),
                Genre = movieDTO.Genre,
                Cover = await FileToByteArray.ImageToByteArray(movieDTO.Cover)
            };

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
    }
}

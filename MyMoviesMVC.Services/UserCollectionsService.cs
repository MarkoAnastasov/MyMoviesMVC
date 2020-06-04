using Microsoft.AspNetCore.Identity;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Common.Helpers.Converters;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.UserMovies;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Services
{
    public class UserCollectionsService : IUserCollectionsService
    {
        private readonly IUserCollectionsRepository _userCollectionsRepository;

        private readonly UserManager<User> _userManager;

        public UserCollectionsService(IUserCollectionsRepository userCollectionsRepository, UserManager<User> userManager)
        {
            _userCollectionsRepository = userCollectionsRepository;
            _userManager = userManager;
        }

        public async Task<List<UserMovieDTO>> GetUserMoviesAsync(ClaimsPrincipal sessionUser)
        {
            var currentUser = await _userManager.GetUserAsync(sessionUser);

            if(currentUser == null)
            {
                return new List<UserMovieDTO>();
            }

            var userMoviesIncluded = await _userCollectionsRepository.GetUserByIdIncludedMoviesAsync(currentUser.Id);

            return userMoviesIncluded.UserMovies.Select(x => ModelToDTO.UserMovieToDTO(x)).ToList();
        }

        public async Task<CheckUserMovieDTO> CheckIfUserMovieAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var userMoviesIncluded = await UserMoviesIncludedCheckNullAsync(sessionUser);

            var targetMovie = userMoviesIncluded.UserMovies.FirstOrDefault(x => x.MovieId == movieId);

            if(targetMovie == null)
            {
                return new CheckUserMovieDTO(false, false, false);
            }

            return new CheckUserMovieDTO(true, targetMovie.IsFavourite, targetMovie.IsWatched);
        }

        public async Task AddUserMovieAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var userMoviesIncluded = await UserMoviesIncludedCheckNullAsync(sessionUser);

            var alreadyAssigned = userMoviesIncluded.UserMovies.FirstOrDefault(x => x.MovieId == movieId);

            if (alreadyAssigned != null)
            {
                throw new FlowException("User already has this movie!");
            }

            userMoviesIncluded.UserMovies.Add(DTOToModel.AddUserMovieToUserMovie(movieId, userMoviesIncluded.Id));

            _userCollectionsRepository.Update(userMoviesIncluded);
            await _userCollectionsRepository.SaveEntitiesAsync();
        }

        public async Task ManageUserMovieAsync(ManageUserMovieDTO manageUserMovieDTO, ClaimsPrincipal sessionUser)
        {
            var userMoviesIncluded = await UserMoviesIncludedCheckNullAsync(sessionUser);

            var assignedMovie = userMoviesIncluded.UserMovies.FirstOrDefault(x => x.MovieId == manageUserMovieDTO.MovieId);

            if (assignedMovie == null)
            {
                throw new FlowException("User does not have this movie!");
            }

            ManageUserMovieCases(manageUserMovieDTO, assignedMovie);

            _userCollectionsRepository.Update(userMoviesIncluded);
            await _userCollectionsRepository.SaveEntitiesAsync();
        }

        public async Task RemoveUserMovieAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var userMoviesIncluded = await UserMoviesIncludedCheckNullAsync(sessionUser);

            var assignedMovie = userMoviesIncluded.UserMovies.FirstOrDefault(x => x.MovieId == movieId);

            if (assignedMovie == null)
            {
                throw new FlowException("User does not have this movie!");
            }

            userMoviesIncluded.UserMovies.Remove(assignedMovie);

            _userCollectionsRepository.Update(userMoviesIncluded);
            await _userCollectionsRepository.SaveEntitiesAsync();
        }

        private void ManageUserMovieCases(ManageUserMovieDTO manageUserMovieDTO, UserMovies assignedMovie)
        {
            switch (manageUserMovieDTO.ActionName)
            {
                case "favourite":
                    if (assignedMovie.IsFavourite == true)
                    {
                        throw new FlowException("Movie already favourite!");
                    }
                    assignedMovie.IsFavourite = true;
                    break;
                case "unfavourite":
                    if (assignedMovie.IsFavourite == false)
                    {
                        throw new FlowException("Movie already unfavourited!");
                    }
                    assignedMovie.IsFavourite = false;
                    break;
                case "watched":
                    if (assignedMovie.IsWatched == true)
                    {
                        throw new FlowException("Movie already watched!");
                    }
                    assignedMovie.IsWatched = true;
                    break;
                case "unwatch":
                    if (assignedMovie.IsWatched == false)
                    {
                        throw new FlowException("Movie already unwatched!");
                    }
                    assignedMovie.IsWatched = false;
                    break;
                default:
                    {
                        throw new FlowException("Option not found!");
                    }
            }
        }

        private async Task<User> UserMoviesIncludedCheckNullAsync(ClaimsPrincipal sessionUser)
        {
            var currentUser = await _userManager.GetUserAsync(sessionUser);

            if (currentUser == null)
            {
                throw new FlowException("An error has occured,try again later");
            }

            return await _userCollectionsRepository.GetUserByIdIncludedMoviesAsync(currentUser.Id);
        }
    }
}

using Microsoft.Extensions.Configuration;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Common.Helpers.Converters;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.UserMovie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Services
{
    public class UserMovieService : IUserMovieService
    {
        private readonly IUserMovieRepository _userMovieRepository;
        private readonly IConfiguration _configuration;

        public UserMovieService(IUserMovieRepository userMovieRepository, IConfiguration configuration)
        {
            _userMovieRepository = userMovieRepository;
            _configuration = configuration;
        }

        public async Task<List<UserMovieDTO>> GetUserMoviesAsync(ClaimsPrincipal sessionUser)
        {
            var currentUserId = Convert.ToInt32(sessionUser.FindFirst("Id").Value);

            var userMovies = await _userMovieRepository.GetAllWhereMovieIncludedAsync(x => x.UserId == currentUserId);

            return userMovies.Select(x => ModelToDTO.UserMovieToDTO(x)).ToList();
        }

        public async Task<CheckUserMovieDTO> CheckIfUserMovieAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var targetMovie = await GetUserMovieByUserIdAsync(movieId, sessionUser);

            if (targetMovie == null)
            {
                return new CheckUserMovieDTO(false, false, false);
            }

            return new CheckUserMovieDTO(true, targetMovie.IsFavourite, targetMovie.IsWatched);
        }

        public async Task AddUserMovieAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var alreadyAssigned = await GetUserMovieByUserIdAsync(movieId, sessionUser);

            if (alreadyAssigned != null)
            {
                throw new FlowException("User already has this movie!");
            }

            var currentUserId = Convert.ToInt32(sessionUser.FindFirst("Id").Value);

            _userMovieRepository.Add(DTOToModel.AddUserMovieToUserMovie(movieId, currentUserId));
            await _userMovieRepository.SaveEntitiesAsync();
        }

        public async Task ManageUserMovieAsync(ManageUserMovieDTO manageUserMovieDTO, ClaimsPrincipal sessionUser)
        {
            var assignedMovie = await GetUserMovieByUserIdAsync(manageUserMovieDTO.MovieId, sessionUser);

            if (assignedMovie == null)
            {
                throw new FlowException("User does not have this movie!");
            }

            ManageUserMovieCases(manageUserMovieDTO, assignedMovie);

            _userMovieRepository.Update(assignedMovie);
            await _userMovieRepository.SaveEntitiesAsync();
        }

        public async Task RemoveUserMovieAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var assignedMovie = await GetUserMovieByUserIdAsync(movieId, sessionUser);

            if (assignedMovie == null)
            {
                throw new FlowException("User does not have this movie!");
            }

            _userMovieRepository.Remove(assignedMovie);
            await _userMovieRepository.SaveEntitiesAsync();
        }

        private void ManageUserMovieCases(ManageUserMovieDTO manageUserMovieDTO, UserMovie assignedMovie)
        {
            if(manageUserMovieDTO.ActionName == _configuration["ManageMovieCases:favourite"])
            {
                if (assignedMovie.IsFavourite == true)
                {
                    throw new FlowException("Movie already favourite!");
                }

                assignedMovie.IsFavourite = true;
            }
            else if(manageUserMovieDTO.ActionName == _configuration["ManageMovieCases:unfavourite"])
            {
                if (assignedMovie.IsFavourite == false)
                {
                    throw new FlowException("Movie already unfavourited!");
                }

                assignedMovie.IsFavourite = false;
            }
            else if (manageUserMovieDTO.ActionName == _configuration["ManageMovieCases:watched"])
            {
                if (assignedMovie.IsWatched == true)
                {
                    throw new FlowException("Movie already watched!");
                }

                assignedMovie.IsWatched = true;
            }
            else if (manageUserMovieDTO.ActionName == _configuration["ManageMovieCases:unwatch"])
            {
                if (assignedMovie.IsWatched == false)
                {
                    throw new FlowException("Movie already unwatched!");
                }

                assignedMovie.IsWatched = false;
            }
        }

        private async Task<UserMovie> GetUserMovieByUserIdAsync(int movieId, ClaimsPrincipal sessionUser)
        {
            var currentUserId = Convert.ToInt32(sessionUser.FindFirst("Id").Value);

            var targetMovie = await _userMovieRepository.GetFirstWhereAsync(x => x.MovieId == movieId && x.UserId == currentUserId);

            return targetMovie;
        }
    }
}

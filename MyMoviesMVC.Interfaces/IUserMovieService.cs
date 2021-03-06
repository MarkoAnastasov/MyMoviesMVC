﻿using MyMoviesMVC.ModelsDTO.UserMovie;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IUserMovieService
    {
        Task<List<UserMovieDTO>> GetUserMoviesAsync(ClaimsPrincipal sessionUser);

        Task<CheckUserMovieDTO> CheckIfUserMovieAsync(int movieId, ClaimsPrincipal sessionUser);

        Task AddUserMovieAsync(int movieId, ClaimsPrincipal sessionUser);

        Task ManageUserMovieAsync(ManageUserMovieDTO manageUserMovieDTO, ClaimsPrincipal sessionUser);

        Task RemoveUserMovieAsync(int movieId, ClaimsPrincipal sessionUser);
    }
}

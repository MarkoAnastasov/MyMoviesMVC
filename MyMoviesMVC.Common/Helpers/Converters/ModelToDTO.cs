﻿using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Movie;
using MyMoviesMVC.ModelsDTO.User;
using System;
using System.Net.NetworkInformation;

namespace MyMoviesMVC.Common.Helpers.Converters
{
    public static class ModelToDTO
    {
        public static MovieMainDTO MovieToMovieMainDTO(Movie movie)
        {
            var mainMovieDTO = new MovieMainDTO()
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                Description = movie.Description,
                Cover = Convert.ToBase64String(movie.Cover)
            };

            return mainMovieDTO;
        }

        public static UserMainDTO UserToUserMainDTO(User user)
        {
            var userMainDTO = new UserMainDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ProfilePicture = Convert.ToBase64String(user.ProfilePicture)
            };

            return userMainDTO;
        }
    }
}

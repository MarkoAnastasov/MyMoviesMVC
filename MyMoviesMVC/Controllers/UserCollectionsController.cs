using Microsoft.AspNetCore.Mvc;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.ModelsDTO.UserMovies;
using System;
using System.Threading.Tasks;

namespace MyMoviesMVC.Controllers
{
    public class UserCollectionsController : Controller
    {
        private readonly IUserCollectionsService _userCollectionsService;

        public UserCollectionsController(IUserCollectionsService userCollectionsService)
        {
            _userCollectionsService = userCollectionsService;
        }

        [HttpGet]
        public async Task<IActionResult> UserMovies()
        {
            try
            {
                var userMoviesDTO = await _userCollectionsService.GetUserMoviesAsync(User);

                return View(userMoviesDTO);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("checkmovie/{movieId}")]
        public async Task<IActionResult> CheckIfUserMovie(int movieId)
        {
            try
            {
                var result = await _userCollectionsService.CheckIfUserMovieAsync(movieId,User);

                return Ok(result);
            }
            catch (FlowException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500,"An error has occured!Try again later!");
            }
        }

        [HttpPost]
        [Route("addusermovie")]
        public async Task<IActionResult> AddUserMovie([FromBody]ManageUserMovieDTO manageUserMovieDTO)
        {
            try
            {
                await _userCollectionsService.AddUserMovieAsync(manageUserMovieDTO.MovieId, User);

                return Ok();
            }
            catch (FlowException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occured!Try again later!");
            }
        }

        [HttpPost]
        [Route("manageusermovie")]
        public async Task<IActionResult> ManageUserMovie([FromBody]ManageUserMovieDTO manageUserMovieDTO)
        {
            try
            {
                await _userCollectionsService.ManageUserMovieAsync(manageUserMovieDTO, User);

                return Ok();
            }
            catch (FlowException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occured!Try again later!");
            }
        }

        [HttpPost]
        [Route("removeusermovie")]
        public async Task<IActionResult> RemoveUserMovie([FromBody]ManageUserMovieDTO manageUserMovieDTO)
        {
            try
            {
                await _userCollectionsService.RemoveUserMovieAsync(manageUserMovieDTO.MovieId, User);

                return Ok();
            }
            catch (FlowException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occured!Try again later!");
            }
        }
    }
}
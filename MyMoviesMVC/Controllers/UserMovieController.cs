using Microsoft.AspNetCore.Mvc;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.ModelsDTO.UserMovie;
using System;
using System.Threading.Tasks;

namespace MyMoviesMVC.Controllers
{
    public class UserMovieController : Controller
    {
        private readonly IUserMovieService _userMovieService;

        public UserMovieController(IUserMovieService userMovieService)
        {
            _userMovieService = userMovieService;
        }

        [HttpGet]
        public async Task<IActionResult> UserMovies()
        {
            try
            {
                var userMoviesDTO = await _userMovieService.GetUserMoviesAsync(User);

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
                var result = await _userMovieService.CheckIfUserMovieAsync(movieId,User);

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
                await _userMovieService.AddUserMovieAsync(manageUserMovieDTO.MovieId, User);

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
                await _userMovieService.ManageUserMovieAsync(manageUserMovieDTO, User);

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
                await _userMovieService.RemoveUserMovieAsync(manageUserMovieDTO.MovieId, User);

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
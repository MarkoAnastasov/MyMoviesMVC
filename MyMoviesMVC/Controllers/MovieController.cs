using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.ModelsDTO.Movie;
using System;
using System.Threading.Tasks;

namespace MyMoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Overview()
        {
            try
            {
                var movies = await _movieService.GetAllMovies();

                return View(movies);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("movie/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var movie = await _movieService.GetTargetMovie(id);

                return View(movie);
            }
            catch (FlowException)
            {
                return RedirectToAction("Overview");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        [Route("addmovie")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search(string title)
        {
            try
            {
                var moviesList = await _movieService.SearchMoviesByTitle(title);

                if (string.IsNullOrEmpty(title))
                {
                    ViewData["SearchTitle"] = "";
                }
                else
                {
                    ViewData["SearchTitle"] = title.Trim();
                }

                return View(moviesList);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("addmovie")]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddMovieDTO movieDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _movieService.AddMovie(movieDTO);

                    return RedirectToAction("Add");
                }

                return View(movieDTO);
            }
            catch (FlowException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                return View(movieDTO);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
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
        [Route("movie/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var movieMainDTO = await _movieService.GetTargetMovieAsync(id);

                if(TempData["AddCommentNote"] != null)
                {
                    ViewData["AddNote"] = TempData["AddCommentNote"];
                }
                else if (TempData["AddCommentError"] != null)
                {
                    ViewData["AddError"] = TempData["AddCommentError"];
                }

                return View(movieMainDTO);
            }
            catch (FlowException)
            {
                return RedirectToAction("UserMovies", "UserMovie");
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
        [Route("editmovie/{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var editMovieDTO = await _movieService.FindMovieAndConvertToEdit(id);

                return View(editMovieDTO);
            }
            catch (FlowException)
            {
                return RedirectToAction("UserMovies", "UserMovie");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("removemovie/{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                await _movieService.RemoveMovieAsync(id);

                return RedirectToAction("UserMovies", "UserMovie");
            }
            catch (FlowException)
            {
                return RedirectToAction("UserMovies", "UserMovie");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search(string title)
        {
            try
            {
                var moviesList = await _movieService.SearchMoviesByTitleAsync(title);

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
        public async Task<IActionResult> Add(AddMovieDTO addMovieDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _movieService.AddMovieAsync(addMovieDTO);

                    return RedirectToAction("Add");
                }

                return View(addMovieDTO);
            }
            catch (FlowException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                return View(addMovieDTO);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("editmovie/{id}")]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,EditMovieDTO editMovieDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _movieService.EditMovieAsync(id,editMovieDTO);

                    return RedirectToAction("Details",id);
                }

                return View(editMovieDTO);
            }
            catch (FlowException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                return View(editMovieDTO);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
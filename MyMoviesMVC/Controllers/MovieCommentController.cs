using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.ModelsDTO.MovieComment;
using System;
using System.Threading.Tasks;

namespace MyMoviesMVC.Controllers
{
    public class MovieCommentController : Controller
    {
        private readonly IMovieCommentService _movieCommentService;

        public MovieCommentController(IMovieCommentService movieCommentService)
        {
            _movieCommentService = movieCommentService;
        }

        [HttpGet]
        [Route("approvecomments")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> MovieCommentsApproval()
        {
            try
            {
                var commentsForApprovalDTO = await _movieCommentService.MovieCommentsApproval();

                return View(commentsForApprovalDTO);
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Approve(int commentId)
        {
            try
            {
                await _movieCommentService.ApproveComment(commentId);

                return RedirectToAction("MovieCommentsApproval");
            }
            catch (FlowException)
            {
                return RedirectToAction("MovieCommentsApproval");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Disapprove(int commentId)
        {
            try
            {
                await _movieCommentService.DisapproveComment(commentId);

                return RedirectToAction("MovieCommentsApproval");
            }
            catch (FlowException)
            {
                return RedirectToAction("MovieCommentsApproval");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("removecomment/{commentId}")]
        public async Task<IActionResult> Remove(int commentId)
        {
            try
            {
                await _movieCommentService.RemoveComment(commentId);

                return Redirect(Request.Headers["Referer"].ToString());
            }
            catch (FlowException)
            {
                return Redirect(Request.Headers["Referer"].ToString());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddMovieCommentDTO addMovieCommentDTO)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _movieCommentService.AddComment(addMovieCommentDTO, User);

                    TempData["AddCommentNote"] = "Your comment has been posted.It will show up after approval.";

                    return RedirectToAction("Details", "Movie", new { id = addMovieCommentDTO.MovieId });
                }

                TempData["AddCommentError"] = "Please insert valid format!";

                return RedirectToAction("Details", "Movie", new { id = addMovieCommentDTO.MovieId });
            }
            catch(FlowException ex)
            {
                TempData["AddCommentError"] = ex.Message;

                return RedirectToAction("Details", "Movie", new { id = addMovieCommentDTO.MovieId });
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
        }
    }
}

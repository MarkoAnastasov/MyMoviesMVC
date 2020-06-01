using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MyMoviesMVC.Controllers
{
    [AllowAnonymous]
    public class StatusCodeController : Controller
    {
        [HttpGet]
        [Route("/error/{statusCode}")]
        public IActionResult StatusCodeError(int statusCode)
        {
            try
            {
                if (statusCode != 500)
                {
                    return RedirectToAction("Overview", "Movie");
                }

                return View();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GlobalError()
        {
            return View("StatusCodeError");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;

namespace MyMoviesMVC.Controllers
{
    public class InfoController : Controller
    {
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}

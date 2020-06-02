using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyMoviesMVC.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public IActionResult AdminSection()
        {
            if (TempData["AssignAdminError"] != null)
            {
                ViewData["AssignError"] = TempData["AssignAdminError"];
            }
            else if(TempData["UnAssignAdminError"] != null)
            {
                ViewData["UnAssignError"] = TempData["UnAssignAdminError"];
            }

            return View();
        }
    }
}
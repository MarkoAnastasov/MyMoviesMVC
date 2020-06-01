using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.ModelsDTO.Account;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyMoviesMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("login")]
        public IActionResult LogIn()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
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
        [AllowAnonymous]
        [Route("register")]
        public IActionResult Register()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
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
        [Route("profile")]
        public async Task<IActionResult> Profile()
        {
            try
            {
                var sessionUser = User;

                var userMainDTO = await _accountService.GetUserByClaim(sessionUser);

                if(TempData["UpdateUserErrors"] != null)
                {
                    ViewData["UpdateErrors"] = TempData["PasswordChangeErrors"];
                }
                else if (TempData["PasswordChangeErrors"] != null)
                {
                    ViewData["PasswordErrors"] = TempData["PasswordChangeErrors"];
                }

                return View(userMainDTO);
            }
            catch (FlowException)
            {
                return RedirectToAction("Overview", "Movie");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginDTO loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var succeed = await _accountService.LogInUser(loginModel);

                    if (succeed)
                    {
                        return RedirectToAction("Overview", "Movie");
                    }

                    ModelState.AddModelError(string.Empty, "Incorrect e-mail or password.");
                }

                return View(loginModel);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            try
            {
                await _accountService.LogOutUser();

                return RedirectToAction("LogIn");

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterDTO registerModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var responseList = await _accountService.RegisterUser(registerModel);

                    if (!responseList.Any())
                    {
                        return RedirectToAction("LogIn");
                    }

                    responseList.ForEach(error => ModelState.AddModelError(string.Empty, error));
                }

                return View(registerModel);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePersonalInfo(UpdatePersonalDTO personalDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sessionUser = User;

                    var responseList = await _accountService.UpdatePersonalInfo(personalDTO, sessionUser);

                    if (!responseList.Any())
                    {
                        return RedirectToAction("Profile");
                    }

                    responseList.ForEach(error => ModelState.AddModelError(string.Empty, error));
                }

                TempData["UpdateUserErrors"] = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();

                return RedirectToAction("Profile");
            }
            catch (FlowException ex)
            {
                TempData["UpdateUserErrors"] = ex.Message;

                return RedirectToAction("Profile");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sessionUser = User;

                    var responseList = await _accountService.ChangePassword(changePasswordDTO, sessionUser);

                    if (!responseList.Any())
                    {
                        return RedirectToAction("Profile");
                    }

                    responseList.ForEach(error => ModelState.AddModelError(string.Empty, error));
                }

                TempData["PasswordChangeErrors"] = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();

                return RedirectToAction("Profile");
            }
            catch (FlowException ex)
            {
                TempData["PasswordChangeErrors"] = ex.Message;

                return RedirectToAction("Profile");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
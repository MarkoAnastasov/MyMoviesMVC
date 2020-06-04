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
                    return RedirectToAction("UserMovies", "UserCollections");
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
                    return RedirectToAction("UserMovies", "UserCollections");
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

                var userMainDTO = await _accountService.GetUserByClaimAsync(sessionUser);

                if(TempData["UpdateUserErrors"] != null)
                {
                    ViewData["UpdateErrors"] = TempData["PasswordChangeErrors"];
                }
                else if (TempData["PasswordChangeErrors"] != null)
                {
                    ViewData["PasswordErrors"] = TempData["PasswordChangeErrors"];
                }
                else if (TempData["RemoveAccountError"] != null)
                {
                    ViewData["RemoveErrors"] = TempData["RemoveAccountError"];
                }

                return View(userMainDTO);
            }
            catch (FlowException)
            {
                return RedirectToAction("UserMovies", "UserCollections");
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
        public async Task<IActionResult> LogIn(LoginDTO loginModel, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var succeed = await _accountService.LogInUserAsync(loginModel);

                    if (string.IsNullOrEmpty(returnUrl) == false && succeed == true)
                    {
                        return Redirect(returnUrl);
                    }

                    if (succeed)
                    {
                        return RedirectToAction("UserMovies", "UserCollections");
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
                await _accountService.LogOutUserAsync();

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
                    var responseList = await _accountService.RegisterUserAsync(registerModel);

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
                    var responseList = await _accountService.UpdatePersonalInfoAsync(personalDTO, User);

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
                    var responseList = await _accountService.ChangePasswordAsync(changePasswordDTO, User);

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(string password)
        {
            try
            {
                var succeed = await _accountService.RemoveAccountAsync(password, User);

                if (succeed)
                {
                    foreach (var cookie in Request.Cookies.Keys)
                    {
                        Response.Cookies.Delete(cookie);
                    }

                    return RedirectToAction("LogIn");
                }

                TempData["RemoveAccountError"] = "An error has occured!Try again later";

                return RedirectToAction("Profile");
            }
            catch (FlowException ex)
            {
                TempData["RemoveAccountError"] = ex.Message;

                return RedirectToAction("Profile");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignUserToAdmin(string userId)
        {
            try
            {
                var succeed = await _accountService.AssignUserToAdminAsync(userId);

                if (succeed)
                {
                    return RedirectToAction("AdminSection", "Admin");
                }

                TempData["AssignAdminError"] = "An error has occured!";

                return RedirectToAction("AdminSection", "Admin");
            }
            catch (FlowException ex)
            {
                TempData["AssignAdminError"] = ex.Message;

                return RedirectToAction("AdminSection", "Admin");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UnAssignUserFromAdmin(string userId)
        {
            try
            {
                var succeed = await _accountService.UnAssignUserFromAdminAsync(userId,User);

                if (succeed)
                {
                    return RedirectToAction("AdminSection", "Admin");
                }

                TempData["UnAssignAdminError"] = "An error has occured!";

                return RedirectToAction("AdminSection", "Admin");
            }
            catch (FlowException ex)
            {
                TempData["UnAssignAdminError"] = ex.Message;

                return RedirectToAction("AdminSection", "Admin");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
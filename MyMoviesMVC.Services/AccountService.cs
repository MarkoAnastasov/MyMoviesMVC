using Microsoft.AspNetCore.Identity;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Common.Helpers.Converters;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.Account;
using MyMoviesMVC.ModelsDTO.User;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountService(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> LogInUser(LoginDTO loginModel)
        {
            var user = await _userManager.FindByEmailAsync(loginModel.Email);

            if(user == null)
            {
                return false;
            }

            var response = await _signInManager.PasswordSignInAsync(user,loginModel.Password, loginModel.StayLoggedIn, false);

            if (response.Succeeded)
            {
                return true;
            }

            return false;
        }

        public async Task LogOutUser()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<List<string>> RegisterUser(RegisterDTO registerDTO)
        {
            var newUser = await DTOToModel.RegisterDTOToUser(registerDTO);

            var response = await _userManager.CreateAsync(newUser, registerDTO.Password);

            var errorList = new List<string>();

            if (response.Succeeded)
            {
                return errorList;
            }

            return ResponseErrors(response, errorList);
        }

        public async Task<UserMainDTO> GetUserByClaim(ClaimsPrincipal sessionUser)
        {
            var targetUser = await _userManager.GetUserAsync(sessionUser);

            if(targetUser == null)
            {
                throw new FlowException();
            }

            return ModelToDTO.UserToUserMainDTO(targetUser);
        }

        public async Task<List<string>> UpdatePersonalInfo(UpdatePersonalDTO personalDTO, ClaimsPrincipal sessionUser)
        {
            var targetUser = await _userManager.GetUserAsync(sessionUser);

            if (targetUser == null)
            {
                throw new FlowException("Account user not found!");
            }

            targetUser = await DTOToModel.UpdatePersonalDTOToUser(personalDTO, targetUser);

            var response = await _userManager.UpdateAsync(targetUser);

            var errorList = new List<string>();

            if (response.Succeeded)
            {
                return errorList;
            }

            return ResponseErrors(response, errorList);
        }

        public async Task<List<string>> ChangePassword(ChangePasswordDTO changePasswordDTO, ClaimsPrincipal sessionUser)
        {
            var targetUser = await _userManager.GetUserAsync(sessionUser);

            if (targetUser == null)
            {
                throw new FlowException("Account user not found!");
            }

            var response = await _userManager.ChangePasswordAsync(targetUser, changePasswordDTO.OldPassword, changePasswordDTO.NewPassword);

            var errorList = new List<string>();

            if (response.Succeeded)
            {
                return errorList;
            }

            return ResponseErrors(response, errorList);
        }

        private static List<string> ResponseErrors(IdentityResult response, List<string> errorList)
        {
            foreach (var error in response.Errors)
            {
                errorList.Add(error.Description);
            }

            return errorList;
        }
    }
}

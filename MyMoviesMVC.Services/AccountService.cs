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

        public async Task<bool> LogInUserAsync(LoginDTO loginModel)
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

        public async Task LogOutUserAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<List<string>> RegisterUserAsync(RegisterDTO registerDTO)
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

        public async Task<UserOverviewDTO> GetUserByClaimAsync(ClaimsPrincipal sessionUser)
        {
            var targetUser = await GetUserByClaimCheckNullAsync(sessionUser);

            return ModelToDTO.UserToUserMainDTO(targetUser);
        }

        public async Task<List<string>> UpdatePersonalInfoAsync(UpdatePersonalDTO personalDTO, ClaimsPrincipal sessionUser)
        {
            var targetUser = await GetUserByClaimCheckNullAsync(sessionUser);

            targetUser = await DTOToModel.UpdatePersonalDTOToUser(personalDTO, targetUser);

            var response = await _userManager.UpdateAsync(targetUser);

            var errorList = new List<string>();

            if (response.Succeeded)
            {
                return errorList;
            }

            return ResponseErrors(response, errorList);
        }

        public async Task<List<string>> ChangePasswordAsync(ChangePasswordDTO changePasswordDTO, ClaimsPrincipal sessionUser)
        {
            var targetUser = await GetUserByClaimCheckNullAsync(sessionUser);

            var response = await _userManager.ChangePasswordAsync(targetUser, changePasswordDTO.OldPassword, changePasswordDTO.NewPassword);

            var errorList = new List<string>();

            if (response.Succeeded)
            {
                return errorList;
            }

            return ResponseErrors(response, errorList);
        }

        public async Task<bool> RemoveAccountAsync(string password,ClaimsPrincipal sessionUser)
        {
            var targetUser = await GetUserByClaimCheckNullAsync(sessionUser);

            var correctPassword = await _userManager.CheckPasswordAsync(targetUser, password);

            if(!correctPassword)
            {
                throw new FlowException("Incorrect password!");
            }

            var response = await _userManager.DeleteAsync(targetUser);

            if (response.Succeeded)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> AssignUserToAdminAsync(string userId)
        {
            var targetUser = await _userManager.FindByIdAsync(userId);

            if(targetUser == null)
            {
                throw new FlowException("User not found!");
            }

            var isAdmin = await _userManager.IsInRoleAsync(targetUser, "admin");

            if(isAdmin)
            {
                throw new FlowException("User already admin!");
            }

            var response = await _userManager.AddToRoleAsync(targetUser, "admin");

            if (response.Succeeded)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> UnAssignUserFromAdminAsync(string userId,ClaimsPrincipal sessionUser)
        {
            var targetUser = await _userManager.FindByIdAsync(userId);

            if (targetUser == null)
            {
                throw new FlowException("User not found!");
            }

            var currentUser = await _userManager.GetUserAsync(sessionUser);

            if(targetUser.Id == currentUser.Id)
            {
                throw new FlowException("You can't unassign yourself!");
            }

            var isAdmin = await _userManager.IsInRoleAsync(targetUser, "admin");

            if (!isAdmin)
            {
                throw new FlowException("User not an admin!");
            }

            var response = await _userManager.RemoveFromRoleAsync(targetUser, "admin");

            if (response.Succeeded)
            {
                return true;
            }

            return false;
        }

        private async Task<User> GetUserByClaimCheckNullAsync(ClaimsPrincipal sessionUser)
        {
            var targetUser = await _userManager.GetUserAsync(sessionUser);

            if (targetUser == null)
            {
                throw new FlowException("Account user not found!");
            }

            return targetUser;
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

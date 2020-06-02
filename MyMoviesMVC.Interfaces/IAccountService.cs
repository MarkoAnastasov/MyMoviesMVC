using MyMoviesMVC.ModelsDTO.Account;
using MyMoviesMVC.ModelsDTO.User;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IAccountService
    {
        Task<bool> LogInUserAsync(LoginDTO loginModel);

        Task LogOutUserAsync();

        Task<List<string>> RegisterUserAsync(RegisterDTO registerModel);

        Task<UserOverviewDTO> GetUserByClaimAsync(ClaimsPrincipal sessionUser);

        Task<List<string>> UpdatePersonalInfoAsync(UpdatePersonalDTO personalDTO, ClaimsPrincipal sessionUser);

        Task<List<string>> ChangePasswordAsync(ChangePasswordDTO changePasswordDTO, ClaimsPrincipal sessionUser);

        Task<bool> AssignUserToAdminAsync(string userId);

        Task<bool> UnAssignUserFromAdminAsync(string userId, ClaimsPrincipal sessionUser);
    }
}

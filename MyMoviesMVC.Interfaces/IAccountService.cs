using MyMoviesMVC.ModelsDTO.Account;
using MyMoviesMVC.ModelsDTO.User;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IAccountService
    {
        Task<bool> LogInUser(LoginDTO loginModel);

        Task LogOutUser();

        Task<List<string>> RegisterUser(RegisterDTO registerModel);

        Task<UserMainDTO> GetUserByClaim(ClaimsPrincipal sessionUser);

        Task<List<string>> UpdatePersonalInfo(UpdatePersonalDTO personalDTO, ClaimsPrincipal sessionUser);

        Task<List<string>> ChangePassword(ChangePasswordDTO changePasswordDTO, ClaimsPrincipal sessionUser);
    }
}

using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.Account
{
    public class RegisterDTO
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(25)]
        public string Email { get; set; }

        [Required]
        [MinLength(7,ErrorMessage = "Minimum length of password is 7 chars."),MaxLength(20)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])).+$", ErrorMessage = "The Password must contain at least one captial letter.")]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
        [Compare("Password",ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public IFormFile ProfilePicture { get; set; }

    }
}

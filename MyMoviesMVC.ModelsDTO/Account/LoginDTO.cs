using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.Account
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        [MaxLength(25,ErrorMessage = "E-mail length must be no longer than 25 chars.")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage = "E-mail length must be no longer than 20 chars.")]
        public string Password { get; set; }

        public bool StayLoggedIn { get; set; }
    }
}

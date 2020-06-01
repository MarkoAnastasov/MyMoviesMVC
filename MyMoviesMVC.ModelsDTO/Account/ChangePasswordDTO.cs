using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.Account
{
    public class ChangePasswordDTO
    {
        [Required]
        [MaxLength(20)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Confirm Password")]
        [Compare("NewPassword", ErrorMessage = "New passwords don't match.")]
        public string ConfirmPassword { get; set; }

    }
}

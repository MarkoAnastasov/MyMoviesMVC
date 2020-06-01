using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.Account
{
    public class UpdatePersonalDTO
    {
        [Required]
        [MaxLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public IFormFile ProfilePicture { get; set; }
    }
}

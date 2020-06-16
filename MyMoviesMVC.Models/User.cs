using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.Models
{
    public class User : IdentityUser<int>
    {
        public User()
        {
            UserMovies = new List<UserMovie>();
        }

        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public byte[] ProfilePicture { get; set; }

        public virtual List<UserMovie> UserMovies { get; set; }
        public virtual List<MovieComment> MovieComments { get; set; }

    }
}

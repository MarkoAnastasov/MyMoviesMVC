using Microsoft.AspNetCore.Http;
using MyMoviesMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.Movie
{
    public class AddMovieDTO
    {
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        public virtual Genre Genre { get; set; }

        [Required]
        public IFormFile Cover { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
    }
}

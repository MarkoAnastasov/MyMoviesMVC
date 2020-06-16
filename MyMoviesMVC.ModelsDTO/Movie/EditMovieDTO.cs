using Microsoft.AspNetCore.Http;
using MyMoviesMVC.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.Movie
{
    public class EditMovieDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        public virtual Genre Genre { get; set; }

        public IFormFile Cover { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.ModelsDTO.MovieComment
{
    public class AddMovieCommentDTO
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        [MaxLength(400)]
        public string Comment { get; set; }
    }
}

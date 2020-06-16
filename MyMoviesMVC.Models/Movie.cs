using MyMoviesMVC.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMoviesMVC.Models
{
    public class Movie
    {
        public Movie()
        {
            UserMovies = new List<UserMovie>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        public byte[] Cover { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public virtual Genre Genre { get; set; }

        [Required]
        public int Views { get; set; }

        public virtual List<UserMovie> UserMovies { get; set; }
        public virtual List<MovieComment> MovieComments { get; set; }
    }
}

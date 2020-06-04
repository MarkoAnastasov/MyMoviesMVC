using MyMoviesMVC.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMoviesMVC.Models
{
    public partial class Movie
    {
        public Movie()
        {
            UserMovies = new List<UserMovies>();
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

        public virtual List<UserMovies> UserMovies { get; set; }

    }
}

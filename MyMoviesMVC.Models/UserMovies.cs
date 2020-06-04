using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMoviesMVC.Models
{
    public class UserMovies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public bool IsFavourite { get; set; }

        [Required]
        public bool IsWatched { get; set; }


        public virtual User User { get; set; }
        public virtual Movie Movie { get; set; }
    }
}

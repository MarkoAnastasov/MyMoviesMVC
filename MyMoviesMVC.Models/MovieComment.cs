using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.Models
{
    public class MovieComment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        public string Comment { get; set; }

        [Required]
        public bool IsVerified { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}

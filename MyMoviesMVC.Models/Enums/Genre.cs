using System.ComponentModel.DataAnnotations;

namespace MyMoviesMVC.Models.Enums
{
    public enum Genre
    {
        [Display(Name = "Action")]
        Action,
        [Display(Name = "Adventure")]
        Adventure,
        [Display(Name = "Comedy")]
        Comedy,
        [Display(Name = "Crime")]
        Crime,
        [Display(Name = "Drama")]
        Drama,
        [Display(Name = "Fantasy")]
        Fantasy,
        [Display(Name = "Horror")]
        Horror,
        [Display(Name = "Romance")]
        Romance,
        [Display(Name = "Thriller")]
        Thriller
    }
}

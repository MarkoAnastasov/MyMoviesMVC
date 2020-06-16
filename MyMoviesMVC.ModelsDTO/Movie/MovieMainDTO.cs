using MyMoviesMVC.Models.Enums;
using MyMoviesMVC.ModelsDTO.MovieComment;
using System.Collections.Generic;

namespace MyMoviesMVC.ModelsDTO.Movie
{
    public class MovieMainDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Cover { get; set; }

        public string Description { get; set; }

        public virtual Genre Genre { get; set; }

        public int Views { get; set; }

        public List<MovieCommentMainDTO> Comments { get; set; }
    }
}

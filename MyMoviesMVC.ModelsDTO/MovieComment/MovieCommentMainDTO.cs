using MyMoviesMVC.ModelsDTO.User;

namespace MyMoviesMVC.ModelsDTO.MovieComment
{
    public class MovieCommentMainDTO
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public UserOverviewDTO User { get; set; }
    }
}

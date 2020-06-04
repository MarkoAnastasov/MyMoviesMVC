namespace MyMoviesMVC.ModelsDTO.UserMovies
{
    public class UserMovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Cover { get; set; }

        public string Description { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsWatched { get; set; }
    }
}

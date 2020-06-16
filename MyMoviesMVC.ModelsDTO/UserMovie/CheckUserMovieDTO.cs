namespace MyMoviesMVC.ModelsDTO.UserMovie
{
    public class CheckUserMovieDTO
    {
        public CheckUserMovieDTO(bool isUserMovie, bool isFavourite, bool isWatched)
        {
            IsUserMovie = isUserMovie;
            IsFavourite = isFavourite;
            IsWatched = isWatched;
        }

        public bool IsUserMovie { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsWatched { get; set; }

    }
}

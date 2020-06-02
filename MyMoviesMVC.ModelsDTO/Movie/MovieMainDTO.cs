using MyMoviesMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMoviesMVC.ModelsDTO.Movie
{
    public class MovieMainDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Cover { get; set; }

        public string Description { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsWatched { get; set; }

        public virtual Genre Genre { get; set; }
    }
}

using System.Collections.Generic;

namespace imdb_ratings.Models
{
    public class GenreList
    {
        public IEnumerable<MovieGenreModel> Genres { get; set; }
    }

    public class MovieGenreModel
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}

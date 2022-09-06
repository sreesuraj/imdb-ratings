using System.Collections.Generic;

namespace imdb_ratings.Models
{
    public class GenreList
    {
        public List<MovieGenreModel> Genre { get; set; }
    }

    public class MovieGenreModel
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}

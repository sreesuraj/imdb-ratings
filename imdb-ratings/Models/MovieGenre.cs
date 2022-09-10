using System.Collections.Generic;

namespace imdb_ratings.Models
{
    public class GenreList
    {
        public IEnumerable<MovieGenre> Genres { get; set; }
    }

    public class MovieGenre
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

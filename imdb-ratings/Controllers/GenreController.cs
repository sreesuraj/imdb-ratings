using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using imdb_ratings.Models;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace imdb_ratings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        // GET api/<GenreController>/5
        [HttpGet("movies/genres")]
        public List<string> Get(string language)
        {
            List<string> movieGenreList = new List<string>();
            using (WebClient web = new WebClient())
            {
                string token = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJhNmZmNGY1YzkzODVjNDZmMWU0YTVlNDM3NzM2YzcxNyIsInN1YiI6IjYzMTY1YTM5MzI2YzE5MDA3ZjJkMjQ4YSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.7pgrgqfgQwC4JdTIX1dajtXu7xslEnnPX3RZcmzhKy4";
                string url = string.Format("https://api.themoviedb.org/3/genre/movie/list?language={0}", language);
                web.Headers.Add("Authorization", "Bearer " + token);
                string response = web.DownloadString(url);
                GenreList genreList = JsonConvert.DeserializeObject<GenreList>(response);

                var genre = genreList.Genres.ToList();
                movieGenreList = genre.Select(x=>x.Name).ToList();
            }
             return movieGenreList;
        }
    }

    internal class FromUriAttribute : Attribute
    {
    }
}

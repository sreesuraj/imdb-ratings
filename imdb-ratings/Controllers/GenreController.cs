using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using imdb_ratings.Models;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace imdb_ratings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        // GET api/<GenreController>/5
        [HttpGet("{language}")]
        public List<string> Get(string language)
        {
            List<string> movieList = new List<string>();
            using (WebClient web = new WebClient())
            {
                string token = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJhNmZmNGY1YzkzODVjNDZmMWU0YTVlNDM3NzM2YzcxNyIsInN1YiI6IjYzMTY1YTM5MzI2YzE5MDA3ZjJkMjQ4YSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.7pgrgqfgQwC4JdTIX1dajtXu7xslEnnPX3RZcmzhKy4";
                string url = string.Format("https://api.themoviedb.org/3/genre/tv/list?language={0}", language);
                web.Headers.Add("Authorization", "Bearer " + token);
                string response = web.DownloadString(url);
                //GenreList genreList = JsonSerializer.Deserialize<GenreList>(response);
                GenreList genreList = JsonConvert.DeserializeObject<GenreList>(response);


            }
            return movieList;
        }
    }
}

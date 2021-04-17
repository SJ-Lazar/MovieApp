using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
         return new List<Movie>()
         {
             new Movie() {Title = "Avengers:End Game", ReleaseDate = new DateTime(2020, 3, 4), 
                 Poster = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg" },
             new Movie()
             {
                 Title = "Lion King", ReleaseDate = new DateTime(2020, 7, 28),
                 Poster = "https://m.media-amazon.com/images/M/MV5BMjIwMjE1Nzc4NV5BMl5BanBnXkFtZTgwNDg4OTA1NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"
             },
             new Movie()
             {
                 Title = "John Wick", ReleaseDate = new DateTime(2016, 5, 31),
                 Poster = "https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_UX182_CR0,0,182,268_AL_.jpg"
             }
         };
        }
    }
}

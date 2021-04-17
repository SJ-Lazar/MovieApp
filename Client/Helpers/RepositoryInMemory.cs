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
             new Movie() {Title = "Avengers: End Game", ReleaseDate = new DateTime(2020, 3, 4)},
             new Movie() {Title = "Lion King", ReleaseDate = new DateTime(2020, 7, 28)},
             new Movie() {Title = "John Wick", ReleaseDate = new DateTime(2016, 5, 31)}
         };
        }
    }
}

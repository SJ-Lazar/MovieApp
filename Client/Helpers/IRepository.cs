using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}

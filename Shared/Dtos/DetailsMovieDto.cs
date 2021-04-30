using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Shared.Entities;

namespace MovieApp.Shared.Dtos
{
    public class DetailsMovieDto
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Actors { get; set; }

    }
}

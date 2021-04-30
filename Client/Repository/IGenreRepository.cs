using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
        Task<List<Genre>> GetGenres();
        Task<Genre> GetGenre(int Id);
        Task UpdateGenre(Genre genre);
        Task DeleteGenre(int id);
    }
}

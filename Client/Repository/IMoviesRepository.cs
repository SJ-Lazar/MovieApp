using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Dtos;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Repository
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);
        Task<IndexPageDto> GetIndexPagedDto();
        Task<DetailsMovieDto> GetDetailsMovieDto(int id);
        Task<MovieUpdateDto> GetMovieForUpdate(int id);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(int Id);
        Task<PaginatedResponse<List<Movie>>> GetMoviesFiltered(FilterMoviesDto filterMoviesDto);
    }
}

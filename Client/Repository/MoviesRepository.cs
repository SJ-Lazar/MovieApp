using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Client.Helpers;
using MovieApp.Shared.Dtos;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private string url = "api/movies";
        private readonly IHttpService _httpService;

        public MoviesRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<MovieUpdateDto> GetMovieForUpdate(int id)
        {
            return await _httpService.GetHelper<MovieUpdateDto>($"{url}/update/{id}");
        }
        public async Task<IndexPageDto> GetIndexPagedDto()
        {
            return await _httpService.GetHelper<IndexPageDto>(url);
        }
        public async Task<DetailsMovieDto> GetDetailsMovieDto(int id)
        {
            return await _httpService.GetHelper<DetailsMovieDto>($"{url}/{id}");
        }
        public async Task UpdateMovie(Movie movie)
        {
            var response = await _httpService.Put(url, movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        private async Task<T> Get<T>(string url)
        {
            var response = await _httpService.Get<T>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
        public async Task<int> CreateMovie(Movie movie)
        {
            var response = await _httpService.Post<Movie, int>(url, movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
        public async Task<PaginatedResponse<List<Movie>>> GetMoviesFiltered(FilterMoviesDto filterMoviesDto)
        {
            var responseHTTP = await _httpService.Post<FilterMoviesDto, List<Movie>>($"{url}/filter", filterMoviesDto);
            var totalAmountPages = int.Parse(responseHTTP.HttpResponseMessage.Headers.GetValues("totalAmountPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<List<Movie>>()
            {
                Response = responseHTTP.Response,
                TotalAmountPages = totalAmountPages
            };

            return paginatedResponse;
        }
        public async Task DeleteMovie(int Id)
        {
            var response = await _httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

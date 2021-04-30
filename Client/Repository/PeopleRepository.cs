using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Client.Helpers;
using MovieApp.Shared.Dtos;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private string url = "api/people";
        private readonly IHttpService _httpService;

        public PeopleRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDto paginationDto)
        {
            return await _httpService.GetHelper<List<Person>>(url, paginationDto);
        }
        public async Task CreatePerson(Person person)
        {
            var response = await _httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Person>> GetPeopleByName(string name)
        {
            var response = await _httpService.Get<List<Person>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
        public async Task<Person> GetPersonById(int id)
        {
            return await _httpService.GetHelper<Person>($"{url}/{id}");
        }
        public async Task UpdatePerson(Person person)
        {
            var response = await _httpService.Put(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeletePerson(int Id)
        {
            var response = await _httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

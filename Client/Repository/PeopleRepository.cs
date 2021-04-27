using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Client.Helpers;
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
        public async Task<List<Person>> GetPeople()
        {
            var response = await _httpService.Get<List<Person>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
        public async Task CreatePerson(Person person)
        {
            var response = await _httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Dtos;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Repository
{
    public interface IPeopleRepository
    {
        Task CreatePerson(Person person);
        Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDto paginationDto);
        Task<List<Person>> GetPeopleByName(string name);
        Task UpdatePerson(Person person);
        Task DeletePerson(int Id);
        Task<Person> GetPersonById(int id);
    }
}

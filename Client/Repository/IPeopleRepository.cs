using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Repository
{
    public interface IPeopleRepository
    {
        Task CreatePerson(Person person);
        Task<List<Person>> GetPeople();
    }
}

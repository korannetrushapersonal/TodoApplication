using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Entities;

namespace TodoApi.Data
{
    public interface IPersonRepository
    {
       Task<Person> AddPersonAsync(Person newItem);



        Task<Person> DeletePersonAsync(int deletedId);



       IEnumerable<Person> GetAllPersons();


         Person GetPersonById(int Id);

        IEnumerable<TodoItem> GetItemsForPerson(int Id);


        Task<Person> UpdatePersonAsync(Person changedItem);

    }
}
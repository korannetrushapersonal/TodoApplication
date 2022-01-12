using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Entities;

namespace TodoApi.EntityFramework
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Person> AddPersonAsync(Person newItem)
        {
            _context.Persons.Add(newItem);
            await _context.SaveChangesAsync();
            return newItem;
        }


        public async Task<Person> DeletePersonAsync(int deletedId)
        {
            var person=_context.Persons.FirstOrDefault(x => x.PersonId == deletedId);
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
            return person;
        }


        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Persons.Include(x=>x.TodoItems);
        }

        public Person GetPersonById(int Id)
        {
            return _context.Persons.Include(x=>x.TodoItems).FirstOrDefault(e => e.PersonId == Id);
        }

        public IEnumerable<TodoItem> GetItemsForPerson(int Id)
        {
            return _context.TodoItems.Include(x=>x.person).Where(x => x.PersonId == Id);
        }

        public async Task<Person> UpdatePersonAsync(Person changedItem)
        {
            _context.Persons.Update(changedItem);
            await _context.SaveChangesAsync();
            return changedItem;
        }

       

    }
}

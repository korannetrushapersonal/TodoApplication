using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Data;
using TodoApi.Entities;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        private readonly IPersonRepository _personRepository;

        public PersonController(
            ILogger<PersonController> logger,
            IPersonRepository personRepository
        )
        {
            _logger = logger;
            _personRepository = personRepository;
        }

        /// <summary>
        /// Method to add a new person to the database
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Person> AddPersonAsync([FromBody]Person newItem)
        {
            try
            {
                return await _personRepository.AddPersonAsync(newItem);
            }
            catch
            {
                _logger.LogError("Error occured in AddPersonASync method in Person Controller. Input: {newItem}", newItem);
                return null;
            }
        }

        /// <summary>
        /// Method to delete person with specified Id
        /// </summary>
        /// <param name="deletedId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{Id}")]
        public async Task<Person> DeletePersonAsync([FromRoute]int deletedId)
        {
            try
            {
                return await _personRepository.DeletePersonAsync(deletedId);
            }
            catch
            {
                _logger.LogError("Error occured in DeletePersonAsync method in Person Controller. Input: {deletedId}", deletedId);
                return null;
            }
        }

        /// <summary>
        /// Method to get all persons
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            try
            {
                return _personRepository.GetAllPersons();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"Error occured in GetAllPersons method in Person Controller.");
                return null;
            }
        }

        /// <summary>
        /// Method to get person by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{Id}")]
        public Person GetPersonById([FromRoute]int Id)
        {
            try
            {
                return _personRepository.GetPersonById(Id);
            }
            catch
            {
                _logger.LogError("Error occured in GetPersonById method in Person Controller. Input: {Id}",Id);
                return null;
            }
        }

        /// <summary>
        /// Method to get Items for Person of specified Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{Id}")]
        public IEnumerable<TodoItem> GetItemsForPerson([FromRoute]int Id)
        {
            try
            {
                return _personRepository.GetItemsForPerson(Id);
            }
            catch
            {
                _logger.LogError("Error occured in GetItemsForPerson method in Person Controller. Input: {Id}", Id);
                return null;
            }
        }

        /// <summary>
        /// Method to update person data
        /// </summary>
        /// <param name="changedItem"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Person> UpdatePersonAsync([FromBody]Person changedItem)
        {
            try
            {
                return await _personRepository.UpdatePersonAsync(changedItem);
            }
            catch
            {
                _logger.LogError("Error occured in UpdatePersonAsync method in Person Controller. Input: {changedItem}", changedItem);
                return null;
            }
        }
    }
}
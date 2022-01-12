using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using TodoApi.Data;
using TodoApi.Entities;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        
        private readonly ITodoRepository _todoRepository;

        public TodoController(
            ILogger<TodoController> logger, 
            ITodoRepository todoRepository
        )
        {
            _logger = logger;
            _todoRepository = todoRepository;
        }

        /// <summary>
        /// Method to Add new item to the database
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TodoItem> AddItemAsync([FromBody]TodoItem newItem)
        {
            try
            {
                return await _todoRepository.AddItemAsync(newItem);
            }
            catch
            {
                _logger.LogError("Error in AddItemAsyncMethod. Input {newItem}", newItem);
                return null;
            }
        }

        /// <summary>
        /// method to delete item from the database
        /// </summary>
        /// <param name="deletedItem"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<TodoItem> DeleteItemAsync([FromBody]TodoItem deletedItem)
        {
            try
            {
                return await _todoRepository.DeleteItemAsync(deletedItem);
            }
            catch
            {
                _logger.LogError("Error in DeleteItemAsync. Input {deletedItem}", deletedItem);
                return null;
            }
        }

        /// <summary>
        /// method to get all items
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<TodoItem> GetAllItems()
        {
            try
            {
                return _todoRepository.GetAllItems();
            }
            catch
            {
                _logger.LogError("Error in GetAllItems.");
                return null;
            }
        }

        /// <summary>
        /// method to get Item by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{Id}")]
        public TodoItem GetItemById([FromRoute]int Id)
        {
            try
            {
                return _todoRepository.GetItemById(Id);
            }
            catch
            {
                _logger.LogError("Error in GetItemById. Input {Id}", Id);
                return null;
            }
        }

        /// <summary>
        /// Method to update Item data
        /// </summary>
        /// <param name="changedItem"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<TodoItem> UpdateItemAsync([FromBody]TodoItem changedItem)
        {
            try
            {
                return await _todoRepository.UpdateItemAsync(changedItem);
            }
            catch
            {
                _logger.LogError("Error in UpdateItemAsync. Input {changedItem}", changedItem);
                return null;
            }
              
        }

        /// <summary>
        /// Method to assign item to person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<TodoItem> AssignItemToPerson([FromBody] TodoItem person)
        {
            try
            {
                return await _todoRepository.AssignItemToPerson(person);
            }
            catch
            {
                _logger.LogError("Error in AssignItemToPerson. Input {person}", person);
                return null;
            }
        }

        /// <summary>
        /// method to bulk assign items to person
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IEnumerable<TodoItem>> BulkAssignItemToPerson([FromBody] IEnumerable<TodoItem> item)
        {
            try
            {
                return await _todoRepository.BulkAssignItemToPerson(item);
            }
            catch
            {
                _logger.LogError("Error in BulkAssignItemToPerson. Input {item}", item);
                return null;
            }
        }
    }
}
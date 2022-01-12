using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Entities;

namespace TodoApi.Data
{
    public interface ITodoRepository
    {
        Task<TodoItem> AddItemAsync(TodoItem newItem);


         Task<TodoItem> DeleteItemAsync(TodoItem deletedItem);


         IEnumerable<TodoItem> GetAllItems();


        TodoItem GetItemById(int Id);


         Task<TodoItem> UpdateItemAsync(TodoItem changedItem);

         Task<TodoItem> AssignItemToPerson(TodoItem item);


        Task<IEnumerable<TodoItem>> BulkAssignItemToPerson(IEnumerable<TodoItem> items);

    }
}
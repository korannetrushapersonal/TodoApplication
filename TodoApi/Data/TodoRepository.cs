using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Entities;

namespace TodoApi.EntityFramework
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext _context;

        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem> AddItemAsync(TodoItem newItem)
        {
            newItem.AddedDateTime = DateTime.Now;
            _context.TodoItems.Add(newItem);
            await _context.SaveChangesAsync();
            return newItem;
        }

        public async Task<TodoItem> DeleteItemAsync(TodoItem deletedItem)
        {
               deletedItem.AddedDateTime = DateTime.Now;
                _context.TodoItems.Remove(deletedItem);
                await _context.SaveChangesAsync();
                return deletedItem;
        }

        public IEnumerable<TodoItem> GetAllItems()
        {
            return _context.TodoItems.Include(x=>x.person);
        }

        public TodoItem GetItemById(int Id)
        {
            return _context.TodoItems.FirstOrDefault(e => e.ItemId == Id);
        }

        public async Task<TodoItem> UpdateItemAsync(TodoItem changedItem)
        {
            
            changedItem.AddedDateTime = DateTime.Now;
             _context.TodoItems.Update(changedItem);
            await _context.SaveChangesAsync();
            return changedItem;
        }
        public async Task<TodoItem> AssignItemToPerson(TodoItem item)
        {
            _context.TodoItems.Update(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<TodoItem>> BulkAssignItemToPerson(IEnumerable<TodoItem> items)
        {
            _context.TodoItems.UpdateRange(items);
            await _context.SaveChangesAsync();
            return items;

        }
    }
}

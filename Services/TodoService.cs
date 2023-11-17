using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoService : ITodoService
    {
        protected readonly TodoContext _dbContext;
        public TodoService(TodoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TodoItem> AddTodoItemAsync(TodoItem todoItem)
        {
            await _dbContext.AddAsync(todoItem);
            await _dbContext.SaveChangesAsync();
            return todoItem;
        }

        public async Task<TodoItem> UpdateTodoItemAsync(TodoItem todoItem)
        {
            var item = await _dbContext.TodoItems.FindAsync(todoItem.Id);
            if (item is null)
            {
                return todoItem;
            }

            item.Name = todoItem.Name;
            item.IsComplete = todoItem.IsComplete;
            await _dbContext.SaveChangesAsync();
            return todoItem;
        }

        public async Task<bool> DeleteTodoItemAsync(long id)
        {
            var todoItem = await _dbContext.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return false;
            }

            _dbContext.TodoItems.Remove(todoItem);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            return await _dbContext.TodoItems.ToListAsync();
        }

        public async Task<TodoItem?> GetTodoItemAsync(long id)
        {
            return await _dbContext.TodoItems.FindAsync(id);
        }
    }
}

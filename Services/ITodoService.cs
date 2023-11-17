using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoService
    {
        Task<TodoItem> AddTodoItemAsync(TodoItem todoItem);
        Task<TodoItem> UpdateTodoItemAsync(TodoItem todoItem);
        Task<bool> DeleteTodoItemAsync(long id);
        Task<IEnumerable<TodoItem>> GetTodoItemsAsync();
        Task<TodoItem?> GetTodoItemAsync(long id);
    }
}

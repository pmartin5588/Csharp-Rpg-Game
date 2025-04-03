using Webshop.Core.Models.Domains;
using Webshop.Core.Models.Dtos;

namespace Webshop.Core.Services
{
    public interface ITodoService
    {
        Todo GetTodo(Guid todoId);
        ICollection<Todo> GetTodos();
        void CreateTodo(CreateTodoDto createTodoDto);
    }
}

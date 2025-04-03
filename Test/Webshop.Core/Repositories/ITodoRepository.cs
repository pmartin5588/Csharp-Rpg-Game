using Webshop.Core.Models.Domains;

namespace Webshop.Core.Repositories
{
    public interface ITodoRepository
    {
        Todo GetTodo(Guid todoId);
        ICollection<Todo> GetTodos();
        void InsertTodo(Todo todo);
    }
}

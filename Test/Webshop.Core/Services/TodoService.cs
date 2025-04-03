using Webshop.Core.Models.Domains;
using Webshop.Core.Models.Dtos;
using Webshop.Core.Repositories;

namespace Webshop.Core.Services
{
    public class TodoService : ITodoService
    {
        private ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public Todo GetTodo(Guid todoId)
        {
            return _todoRepository.GetTodo(todoId);
        }

        public ICollection<Todo> GetTodos()
        {
            return _todoRepository.GetTodos();
        }

        public void CreateTodo(CreateTodoDto createTodoDto)
        {
            var todo = new Todo
            {
                Task = createTodoDto.Task,
                Description = createTodoDto.Description,
                ExpiresOn = createTodoDto.ExpiresOn
            };

            _todoRepository.InsertTodo(todo);
        }
    }
}

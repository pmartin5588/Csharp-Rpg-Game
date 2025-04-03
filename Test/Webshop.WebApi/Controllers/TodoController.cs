using Microsoft.AspNetCore.Mvc;
using System.Net;
using Webshop.Api.Model;
using Webshop.Core.Models.Dtos;
using Webshop.Core.Services;

namespace Webshop.Api.Controllers
{
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        [Route("/todo")]
        public IActionResult GetTodo(Guid todoId)
        {
            try
            {
                return Ok(_todoService.GetTodo(todoId));
            }
            catch
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        [Route("/todos")]
        public IActionResult GetTodos()
        {
            try
            {
                return Ok(_todoService.GetTodos());
            }
            catch
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        [Route("/todo")]
        public IActionResult CreateTodo(CreateTodoRequest createTodoRequest)
        {
            try
            {
                var createTodo = new CreateTodoDto
                {
                    Task = createTodoRequest.Task,
                    Description = createTodoRequest.Description,
                    ExpiresOn = createTodoRequest.ExpiresOn
                };

                _todoService.CreateTodo(createTodo);
            }
            catch
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

            return Created();
        }
    }
}

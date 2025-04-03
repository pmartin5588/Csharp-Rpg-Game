using Npgsql;
using Webshop.Core.Models.Domains;
using Webshop.Core.Repositories;

namespace Webshop.Infrastructure.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public Todo GetTodo(Guid todoId)
        {
            using var connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword");

            connection.Open();

            string sql = $"SELECT * FROM ttodo WHERE task_id = '{todoId}'";

            using var cmd = new NpgsqlCommand(sql, connection);

            using var reader = cmd.ExecuteReader();

            Todo todo = null;
            
            if (reader.Read())
            {
                todo = new Todo
                {
                    TodoId = reader.GetGuid(1),
                    Task = reader.GetString(2),
                    Description = reader.GetString(3),
                    ExpiresOn = reader.GetDateTime(5),
                };
            }

            return todo;
        }

        public ICollection<Todo> GetTodos()
        {
            using var connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword");

            connection.Open();

            string sql = "SELECT * FROM ttodo";

            using var cmd = new NpgsqlCommand(sql, connection);

            using var reader = cmd.ExecuteReader();

            var todos = new List<Todo>();

            while (reader.Read())
            {
                var todo = new Todo
                {
                    TodoId = reader.GetGuid(1),
                    Task = reader.GetString(2),
                    Description = reader.GetString(3),
                    ExpiresOn = reader.GetDateTime(5),
                };

                todos.Add(todo);
            }

            return todos;
        }

        public void InsertTodo(Todo todo)
        {
            using var connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword");

            connection.Open();

            string sql = "INSERT INTO ttodo (task, description, created_on, expires_on) VALUES (@task, @description, @created_on, @expires_on);";

            using var cmd = new NpgsqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("task", todo.Task);
            cmd.Parameters.AddWithValue("description", todo.Description);
            cmd.Parameters.AddWithValue("created_on", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("expires_on", todo.ExpiresOn);

            cmd.ExecuteNonQuery();
        }
    }
}

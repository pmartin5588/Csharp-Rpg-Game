using Webshop.Core.Repositories;
using Webshop.Core.Services;
using Webshop.Infrastructure.Repositories;

namespace Webshop.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddScoped<ITodoService, TodoService>();
            builder.Services.AddScoped<ITodoRepository, TodoRepository>();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();

            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// MySQLの接続文字列※注意
string connectionString = "server=localhost;user=todo;password=todoq;database=todos";

// MySQLのサーバーバージョン※注意
var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));

builder.Services.AddDbContext<TodoContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(UserContext, serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );


builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
using System.Security.Cryptography;
using MMWebApi.Data;
using MMWebApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("v1/todos", (AppDbContext context) => {
    var todos = context.Todos.ToList();
    return Results.Ok(todos);

});

app.Run();

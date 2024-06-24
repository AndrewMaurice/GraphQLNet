using Database;
using GraphQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(c => c.UseInMemoryDatabase("Books_DB"));

builder.Services.AddGraphQLServer()
.AddQueryType<Query>()
.RegisterDbContext<ApplicationDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
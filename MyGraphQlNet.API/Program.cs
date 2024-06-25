using MyGraphQlNet.API.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApiDependencies();
builder.Services.AddGraphQlDependencies();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();

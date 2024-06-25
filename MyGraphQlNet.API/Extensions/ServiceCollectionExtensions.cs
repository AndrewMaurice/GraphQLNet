using MyGraphQlNet.API.GraphQL.Mutations;
using MyGraphQlNet.API.GraphQL.Queries;
using MyGraphQlNet.Application;
using MyGraphQlNet.Persistence.Db;

namespace MyGraphQlNet.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddGraphQlDependencies(this IServiceCollection services)
    {
        services
        .AddGraphQLServer()
        .RegisterDbContext<ApplicationDbContext>()
        .AddQueryType<BooksQuery>()
        .AddMutationType<BooksMutation>()
        .AddInMemorySubscriptions();
    }

    public static IServiceCollection AddApiDependencies(this IServiceCollection services)
    {
        return services.AddApplicationDependencies();
    }
}
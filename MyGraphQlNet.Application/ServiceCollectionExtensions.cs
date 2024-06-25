using Microsoft.Extensions.DependencyInjection;
using MyGraphQlNet.Application.IServices;
using MyGraphQlNet.Application.Services;
using MyGraphQlNet.Persistence;

namespace MyGraphQlNet.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
    {
        return services.AddPersistenceDependencies()
        .AddScoped<IBooksService, BooksService>();
    }
}

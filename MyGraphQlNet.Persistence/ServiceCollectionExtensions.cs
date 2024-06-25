
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyGraphQlNet.Persistence.Db;
using MyGraphQlNet.Persistence.IRepositories;
using MyGraphQlNet.Persistence.Repositories;

namespace MyGraphQlNet.Persistence;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistenceDependencies(this IServiceCollection services)
    {
        return services
        .AddDbContext<ApplicationDbContext>(cnfg => cnfg.UseInMemoryDatabase("BooksDb"))
        .AddScoped<IBooksRepository, BooksRepository>()
        .AddScoped<IUnitOfWork, UnitOfWork>();
    }
}

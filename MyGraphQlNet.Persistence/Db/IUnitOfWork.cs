namespace MyGraphQlNet.Persistence.Db;

public interface IUnitOfWork
{
    Task<int> SaveChanegsAsync();

    int SaveChanges();
}
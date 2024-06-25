
namespace MyGraphQlNet.Persistence.Db;

internal class UnitOfWork : IUnitOfWork
{
    #region Fields

    private readonly ApplicationDbContext _context;

    #endregion

    #region Constructors

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    #endregion 

    #region Methods
    public async Task<int> SaveChanegsAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
    #endregion
}
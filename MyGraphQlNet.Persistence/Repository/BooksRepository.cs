using System.Linq.Expressions;
using Entities;
using Microsoft.EntityFrameworkCore;
using MyGraphQlNet.Persistence.Db;
using MyGraphQlNet.Persistence.IRepositories;

namespace MyGraphQlNet.Persistence.Repositories;

internal class BooksRepository : IBooksRepository
{
    #region Fields

    private readonly DbSet<Book> _set;

    #endregion

    #region Constructors

    public BooksRepository(ApplicationDbContext context)
    {
        _set = context.Set<Book>();
    }

    #endregion

    #region Methods

    public async Task<Book> AddBook(Book newBook)
    {
        await _set.AddAsync(newBook);

        return newBook;
    }

    public async Task<Book> GetBook(Expression<Func<Book, bool>> filterationExpression)
    {
        return await _set.SingleOrDefaultAsync(filterationExpression);
    }

    public async Task<IEnumerable<Book>> GetBooks()
    {
        return await _set.AsNoTracking().ToListAsync();
    }

    #endregion
}
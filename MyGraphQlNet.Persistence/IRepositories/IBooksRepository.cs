using System.Linq.Expressions;
using Entities;

namespace MyGraphQlNet.Persistence.IRepositories;

public interface IBooksRepository
{
    Task<IEnumerable<Book>> GetBooks();

    Task<Book> GetBook(Expression<Func<Book, bool>> filterationExpression);

    Task<Book> AddBook(Book newBook);
}
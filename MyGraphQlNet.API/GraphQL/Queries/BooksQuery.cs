using Entities;
using MyGraphQlNet.Application.IServices;

namespace MyGraphQlNet.API.GraphQL.Queries;

public class BooksQuery
{
    #region Queries

    public async Task<IEnumerable<Book>> Books([Service] IBooksService booksService) => await booksService.GetBooks();

    public async Task<Book> Book(string id, [Service] IBooksService booksService) => await booksService.GetBookById(Guid.Parse(id));

    #endregion
}
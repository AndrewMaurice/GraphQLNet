using Entities;
using MyGraphQlNet.Application.DTOs;
using MyGraphQlNet.Application.IServices;

namespace MyGraphQlNet.API.GraphQL.Mutations;

public class BooksMutation
{
    #region Mutations

    public async Task<Book> AddBook(BookInput book, [Service] IBooksService booksService) => await booksService.AddNewBook(book);

    #endregion
}
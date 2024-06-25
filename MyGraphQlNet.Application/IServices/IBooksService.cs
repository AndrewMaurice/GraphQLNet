using Entities;
using MyGraphQlNet.Application.DTOs;

namespace MyGraphQlNet.Application.IServices;

public interface IBooksService
{
    Task<IEnumerable<Book>> GetBooks();

    Task<Book> GetBookById(Guid bookId);

    Task<Book> AddNewBook(BookInput newBook);
}
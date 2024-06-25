using Entities;
using MyGraphQlNet.Application.DTOs;
using MyGraphQlNet.Application.Exceptions;
using MyGraphQlNet.Application.IServices;
using MyGraphQlNet.Persistence.Db;
using MyGraphQlNet.Persistence.IRepositories;

namespace MyGraphQlNet.Application.Services;

internal class BooksService : IBooksService
{

    #region Fields

    private readonly IBooksRepository _booksRepository;
    private readonly IUnitOfWork _unitOfWork;

    #endregion

    #region Constructor

    public BooksService(IBooksRepository booksRepository, IUnitOfWork unitOfWork)
    {
        _booksRepository = booksRepository;
        _unitOfWork = unitOfWork;
    }

    #endregion

    #region Methods

    public async Task<Book> AddNewBook(BookInput newBook)
    {
        // For complex objects we can use AutoMapper to handle the mapping between the DTOs and the Domain entities.
        Book newBookToBeAdded = new Book(newBook.Name, newBook.NumberOfPages);

        newBookToBeAdded =  await _booksRepository.AddBook(newBookToBeAdded);
        await _unitOfWork.SaveChanegsAsync();

        return newBookToBeAdded;
    }

    public async Task<Book> GetBookById(Guid bookId)
    {
        // we can extend the implementation of custom exception to include HTTP Status Codes and make use of a global excpetion middleware to handle such kind of custom exceptions.
        return await _booksRepository.GetBook(b => b.Id.Equals(bookId)) ?? throw new NotFoundException();
    }

    public async Task<IEnumerable<Book>> GetBooks()
    {
        return await _booksRepository.GetBooks();
    }

    #endregion
}
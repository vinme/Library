using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Application.Interfaces
{
    public interface IBookService
    {
        BooksResourceModel GetBooks();
        Task<BookResponse> AddBook(BookRequest book);
        Task<BookResponse> UpdateBook(BookRequest book);
        Task<BookResponse> GetBookById(int bookId);
    }
}

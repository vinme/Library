
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(Book book);
        Task<Book> GetBookById(int bookId);
    }
}

using ExLib.Domain.Entities;
using ExLib.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Infrastructure.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _dbContext;
        public BookRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book> AddBook(Book book)
        {
            try
            {
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                return book;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Book> GetBookById(int bookId)
        {
            return await _dbContext.Books.AsNoTracking().Where(d => d.Id == bookId)
            .Include(e => e.BookType)
            .Include(f => f.BookStatus)
            .Include(g => g.BookLocation).FirstOrDefaultAsync();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books
            .Include(e => e.BookType)
            .Include(f => f.BookStatus)
            .Include(g => g.BookLocation);
        }

        public async Task<Book> UpdateBook(Book book)
        {
            try
            {
                _dbContext.Books.Update(book);
                _dbContext.SaveChanges();
                return book;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

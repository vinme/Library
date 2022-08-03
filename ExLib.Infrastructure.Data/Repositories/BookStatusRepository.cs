using ExLib.Domain.Entities;
using ExLib.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Infrastructure.Data.Repositories
{
    public class BookStatusRepository : IBookStatusRepository
    {
        public LibraryDbContext _context;
        public BookStatusRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<BookStatus> GetBookStatusList()
        {
            return _context.BookStatus;
        }
    }
}

using ExLib.Domain.Entities;
using ExLib.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Infrastructure.Data.Repositories
{
    public class BookTypeRepository : IBookTypeRepository
    {
        public LibraryDbContext _context;
        public BookTypeRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<BookType> GetBookTypeList()
        {
            return _context.BookType;
        }
    }
}

using ExLib.Domain.Entities;
using ExLib.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Infrastructure.Data.Repositories
{
    public class BookLocationRepository : IBookLocationRepository
    {
        public LibraryDbContext _context;
        public BookLocationRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<BookLocation> GetBookLocationList()
        {
            return _context.BookLocation;
        }
    }
}

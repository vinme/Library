using ExLib.Domain.Interfaces;
using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ExLib.Domain.Entities;

namespace ExLib.Application.Services
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookResponse> AddBook(BookRequest book)
        {
            var bookAdd = _mapper.Map<BookRequest, Book>(book);
            var result = await _bookRepository.AddBook(bookAdd);
            return _mapper.Map<Book, BookResponse>(result);
        }

        public async Task<BookResponse> GetBookById(int bookId)
        {
            var result = await _bookRepository.GetBookById(bookId);
            return _mapper.Map<Book, BookResponse>(result);
        }

        public BooksResourceModel GetBooks()
        {
            return new BooksResourceModel()
            {
                Books = _bookRepository.GetBooks()
            };
        }

        public async Task<BookResponse> UpdateBook(BookRequest book)
        {
            var bookUpdate = _mapper.Map<BookRequest, Book>(book);
            var result = await _bookRepository.UpdateBook(bookUpdate);
            return _mapper.Map<Book, BookResponse>(result);
        }
    }
}

using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Books;
using ExLib.Application.ResourceModels.CheckOuts;
using ExLib.Application.ResourceModels.Comments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ExLib.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;
        private ICommentService _commentService;
        private ICheckOutService _checkOutService;
        public BookController(IBookService bookService, ICommentService commentService, ICheckOutService checkOutService)
        {
            _bookService = bookService;
            _commentService = commentService;
            _checkOutService = checkOutService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            BooksResourceModel model = _bookService.GetBooks();
            return Ok(model);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(BookRequest book)
        {
            try
            {
                var result = await _bookService.AddBook(book);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("Id")]
        public async Task<IActionResult> Id(int bookId)
        {
            try
            {
                var result = await _bookService.GetBookById(bookId);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(BookRequest book)
        {
            try
            {
                var result = await _bookService.UpdateBook(book);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost]
        [Route("AddComment")]
        public async Task<IActionResult> AddComment(CommentRequest comment)
        {
            try
            {
                var result = await _commentService.AddComment(comment);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetComments")]
        public async Task<IActionResult> GetComments(int bookId)
        {
            try
            {
                var result = await _commentService.GetComments(bookId);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("CheckOut")]
        public async Task<IActionResult> CheckOut(BookRequest book)
        {
            try
            {
                var currentBook = await _bookService.GetBookById(book.Id);
                book.Id = currentBook.Id;
                book.Title = currentBook.Title;
                book.Description = currentBook.Description;
                book.Author = currentBook.Author;
                book.Owner = currentBook.Owner;
                book.BookLocationId = currentBook.BookLocationId;
                book.BookTypeId = currentBook.BookTypeId;
                var result = await _bookService.UpdateBook(book);
                if (result == null)
                {
                    return NotFound();
                }
                CheckOutRequest cr = new CheckOutRequest()
                {
                    BookId = book.Id,
                    CheckOutDate = DateTime.Now,
                    ReturnDate = DateTime.Now,
                    User = book.CheckOutBy
                };
                await _checkOutService.AddCheckOut(cr);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

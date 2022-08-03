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
    public class CommentRepository : ICommentRepository
    {
        public LibraryDbContext _dbContext;
        public CommentRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Comment> AddComment(Comment comment)
        {
            try
            {
                _dbContext.Comments.Add(comment);
                _dbContext.SaveChanges();
                return comment;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Comment> GetComments(int bookId)
        {
            return _dbContext.Comments.Where(b => b.BookId == bookId).OrderByDescending(d => d.CommentDate);
        }

    }
}

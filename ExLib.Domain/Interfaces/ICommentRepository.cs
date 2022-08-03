
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Domain.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetComments(int bookId);
        Task<Comment> AddComment(Comment comment);
    }
}

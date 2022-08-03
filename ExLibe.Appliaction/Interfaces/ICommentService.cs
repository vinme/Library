using ExLib.Application.ResourceModels.Comments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Application.Interfaces
{
    public interface ICommentService
    {
        Task<CommentsResourceModel> GetComments(int bookId);
        Task<CommentResponse> AddComment(CommentRequest comment);
    }
}

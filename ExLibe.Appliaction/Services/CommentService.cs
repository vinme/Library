using ExLib.Domain.Interfaces;
using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ExLib.Domain.Entities;
using ExLib.Application.ResourceModels.Comments;
using ExLib.Infrastructure.Data.Repositories;

namespace ExLib.Application.Services
{
    public class CommentService : ICommentService
    {
        public ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }


        public async Task<CommentsResourceModel> GetComments(int bookId)
        {
            return new CommentsResourceModel()
            {
                Comments = _commentRepository.GetComments(bookId)
            };
        }

        public async Task<CommentResponse> AddComment(CommentRequest comment)
        {
            var commentAdd = _mapper.Map<CommentRequest, Comment>(comment);
            var result = await _commentRepository.AddComment(commentAdd);
            return _mapper.Map<Comment, CommentResponse>(result);
        }
    }
}

using AutoMapper;
using ExLib.Application.ResourceModels.Books;
using ExLib.Application.ResourceModels.CheckOuts;
using ExLib.Application.ResourceModels.Comments;
using ExLib.Application.ResourceModels.Common;
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<BookRequest, Book>();
            CreateMap<Book, BookResponse>();
            CreateMap<CommentRequest, Comment>();
            CreateMap<Comment, CommentResponse>();
            CreateMap<CheckOutRequest, CheckOut>();
            CreateMap<CheckOut, CheckOutResponse>();
            CreateMap<BookType, TypeResourceModel>();
            CreateMap<BookStatus, StatusResourceModel>();
            CreateMap<BookLocation, LocationResourceModel>();

        }
    }
}

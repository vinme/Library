using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Comments
{
    public class CommentResponse
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string User { get; set; }
        public int? BookId { get; set; }
        public BookResponse Book { get; set; }
        public DateTime CommentDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Comments
{
    public class CommentRequest
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string User { get; set; }
        public int? BookId { get; set; }
        public DateTime CommentDate { get; set; }
    }
}

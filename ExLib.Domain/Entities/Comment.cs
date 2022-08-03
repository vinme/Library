using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string User { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public DateTime CommentDate { get; set; }
    }
}

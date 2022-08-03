using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Owner { get; set; }
        public string CheckOutBy { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int? BookStatusId { get; set; }
        public BookStatus BookStatus { get; set; }
        public int? BookLocationId { get; set; }
        public BookLocation BookLocation { get; set; }
        public int? BookTypeId { get; set; }
        public BookType BookType { get; set; }

    }
}


using ExLib.Application.ResourceModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Books
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Owner { get; set; }
        public string CheckOutBy { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int BookStatusId { get; set; }
        public StatusResourceModel BookStatus { get; set; }
        public int BookLocationId { get; set; }
        public LocationResourceModel BookLocation { get; set; }
        public int? BookTypeId { get; set; }
        public TypeResourceModel BookType { get; set; }
    }
}

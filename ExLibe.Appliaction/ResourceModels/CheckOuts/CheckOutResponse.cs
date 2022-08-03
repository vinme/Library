using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.CheckOuts
{
    public class CheckOutResponse
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int? BookId { get; set; }
        public BookResponse BookResponse { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Entities
{
    public class CheckOut
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

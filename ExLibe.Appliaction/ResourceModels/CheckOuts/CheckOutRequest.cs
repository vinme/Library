using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.CheckOuts
{
    public class CheckOutRequest
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int? BookId { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

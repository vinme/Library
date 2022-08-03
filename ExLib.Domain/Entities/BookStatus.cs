using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Entities
{
    public class BookStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
    }
}

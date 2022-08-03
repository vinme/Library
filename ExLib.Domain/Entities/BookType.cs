using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Entities
{
    public class BookType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
    }
}

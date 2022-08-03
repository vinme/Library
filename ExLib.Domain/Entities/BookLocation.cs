using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Entities
{
    public class BookLocation
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public bool IsActive { get; set; }
    }
}

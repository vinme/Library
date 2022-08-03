using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Books
{
    public class BooksResourceModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}

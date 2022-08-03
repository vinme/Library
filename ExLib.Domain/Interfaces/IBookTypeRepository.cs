
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Interfaces
{
    public interface IBookTypeRepository
    {
        IEnumerable<BookType> GetBookTypeList();
    }
}

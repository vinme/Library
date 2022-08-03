
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Interfaces
{
    public interface IBookStatusRepository
    {
        IEnumerable<BookStatus> GetBookStatusList();
    }
}

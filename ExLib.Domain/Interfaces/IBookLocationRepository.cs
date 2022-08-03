
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Domain.Interfaces
{
    public interface IBookLocationRepository
    {
        IEnumerable<BookLocation> GetBookLocationList();
    }
}

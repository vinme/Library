
using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Domain.Interfaces
{
    public interface ICheckOutRepository
    {
        IEnumerable<CheckOut> GetCheckOuts();
        Task<CheckOut> AddcheckOut(CheckOut checkOut);
    }
}

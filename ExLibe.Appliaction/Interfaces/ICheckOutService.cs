using ExLib.Application.ResourceModels.CheckOuts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExLib.Application.Interfaces
{
    public interface ICheckOutService
    {
        CheckOutsResourceModel GetCheckOuts();
        Task<CheckOutResponse> AddCheckOut(CheckOutRequest checkOut);
    }
}

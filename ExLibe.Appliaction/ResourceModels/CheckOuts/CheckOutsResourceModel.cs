using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.CheckOuts
{
    public class CheckOutsResourceModel
    {
        public IEnumerable<CheckOut> CheckOuts { get; set; }
    }
}

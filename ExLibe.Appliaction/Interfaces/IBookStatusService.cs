using ExLib.Application.ResourceModels.Books;
using ExLib.Application.ResourceModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.Interfaces
{
    public interface IBookStatusService
    {
        StatusesResourceModel GetStatusList();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Common
{
    public class StatusResourceModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }

    public class StatusesResourceModel
    {
        public IEnumerable<StatusResourceModel> BookStatuses { get; set; }
    }
}

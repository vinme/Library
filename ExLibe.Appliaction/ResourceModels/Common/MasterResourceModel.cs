using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Common
{
    public class MasterResourceModel
    {
        public TypesResourceModel BookTypes { get; set; }
        public LocationsResourceModel BookLocations { get; set; }
        public StatusesResourceModel BookStatuses { get; set; }
    }
}

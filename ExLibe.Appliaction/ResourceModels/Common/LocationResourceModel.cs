using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Common
{
    public class LocationResourceModel
    {
        public int Id { get; set; }
        public string Location { get; set; }
    }

    public class LocationsResourceModel
    {
        public IEnumerable<LocationResourceModel> BookLocations { get; set; }
    }
}

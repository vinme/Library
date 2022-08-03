using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Common
{
    public class TypeResourceModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public class TypesResourceModel
    {
        public IEnumerable<TypeResourceModel> BookTypes { get; set; }
    }
}

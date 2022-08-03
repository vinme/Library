using ExLib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLib.Application.ResourceModels.Comments
{
    public class CommentsResourceModel
    {
        public IEnumerable<Comment> Comments { get; set; }
    }
}

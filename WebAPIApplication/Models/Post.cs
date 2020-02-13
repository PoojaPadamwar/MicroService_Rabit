using System;
using System.Collections.Generic;

namespace WebAPIApplication.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ViewCount { get; set; }
        public bool? IsActive { get; set; }
        public virtual Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApplication.ViewModel
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}

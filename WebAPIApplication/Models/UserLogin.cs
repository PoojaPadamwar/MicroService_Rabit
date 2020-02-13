using System;
using System.Collections.Generic;

namespace WebAPIApplication.Models
{
    public partial class UserLogin
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
    }
}

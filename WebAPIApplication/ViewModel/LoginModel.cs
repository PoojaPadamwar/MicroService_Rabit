using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApplication.ViewModel
{
    public class LoginModel
    {
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfJoing { get; set; }
    }
}

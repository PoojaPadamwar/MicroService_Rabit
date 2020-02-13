using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApplication.Models;
using WebAPIApplication.ViewModel;

namespace WebAPIApplication.Repository
{
    public interface IUserRepository
    {
        Task<LoginModel> Login(UserLogin userLogin);
    }
}

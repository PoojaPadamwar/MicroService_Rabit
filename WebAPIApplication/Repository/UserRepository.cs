using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApplication.Models;
using WebAPIApplication.ViewModel;

namespace WebAPIApplication.Repository
{
    public class UserRepository
    {
        CRUDDBContext db;
        public UserRepository(CRUDDBContext _db)
        {
            db = _db;
        }
        //public async Task<LoginModel> Login(UserLogin userLogin)
        //{
        //    if (db != null)
        //    {
        //        return await(from p in db.UserLogin
        //                     where (p.UserName == userLogin.UserName) && (p.Password == userLogin.Password)
        //                     select new LoginModel
        //                     {
        //                         PostId = p.PostId,
        //                         Title = p.Title,
        //                         Description = p.Description,
        //                         CategoryId = p.CategoryId,
        //                         CategoryName = c.Name,
        //                         CreatedDate = p.CreatedDate
        //                     }).FirstOrDefaultAsync();
        //    }

        //    return null;
        //}
    }
}

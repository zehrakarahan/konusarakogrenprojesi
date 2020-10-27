using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonusarakOgren.Domain.Models;
using KonusarakOgren.WebUI.Models;
using KonusarakOgren.WebUI.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace KonusarakOgren.WebUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            var unregistereduser = TempData["kullanici"];
            TempData["unregistereduser"] = unregistereduser;

            //bu asagı kısmı acarsanız veri kaydetmesi acısından
            //using (var dbContext = new KonusarakOgrenContext())
            //{
            //    //Ensure database is created
            //    dbContext.Database.EnsureCreated();
            //    if (!dbContext.Users.Any())
            //    {
            //        dbContext.Users.AddRange(new User[]
            //            {
            //                 new User{UserName="zehrakarahan",Password="1234" },
            //                 new User{UserName="denizsag",Password="123" }

            //            });
            //        dbContext.SaveChanges();
            //    }
            //}

            return View();
        }
       [HttpPost]
        public IActionResult Login(UserAccount userAccount)
        {
            const string username = "";
            using (var dbContext = new KonusarakOgrenContext())
            {
                //Ensure database is created
                dbContext.Database.EnsureCreated();  
               
                    var user = dbContext.Users.FirstOrDefault(x => x.UserName == userAccount.UserName && x.Password == userAccount.Password);
                    if (user==null)
                    {
                        TempData["kullanici"] = "Kullanıcı Adı veya Şifre Yanlış..";
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        HttpContext.Session.SetString(username, user.UserName);
                        return RedirectToAction("Index","Home");
                    }
            }
 
        }
        
    }
}

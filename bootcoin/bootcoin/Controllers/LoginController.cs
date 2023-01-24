using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using bootcoin.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using bootcoin.Helper;
using Microsoft.AspNetCore.Http;
// using System.Web;
// using System.Web.Mvc;
namespace bootcoin.Controllers
{
    public class LoginController : Controller
    {

        private IConfiguration _config;
        CommonHelper _helper;

        public LoginController(IConfiguration config)
        {
            _config = config;
            _helper = new CommonHelper(_config);
        }

        [HttpGet]


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User userRegister)
        {
            string UserExistsQuery = $"Select * from Users where Email='{userRegister.Email}' and Password ='{userRegister.Password}'";
            bool userExists = _helper.UserAlreadyExists(UserExistsQuery);
            if (userExists)
            {
                string RoleQuery = $"Select * from Users where Email='{userRegister.Email}' and Password ='{userRegister.Password}' and Role = 'Admin'";
                bool role = _helper.UserAlreadyExists(RoleQuery);
                
                HttpContext.Session.SetString("Email", userRegister.Email);
                HttpContext.Session.SetString("Password", userRegister.Password);
                if (role)
                {
                    HttpContext.Session.SetString("Role", "Admin");
                    return RedirectToAction("Teams", "Admin");
                }
                else
                {
                    HttpContext.Session.SetString("Role", "Participant");
                    return RedirectToAction("TeamMember", "Trainee");
                }
            }
            else
            {

                TempData["AlertMessage"] = "User Is Not Registered!";
                return View();
            }
           
        }

        



    }
}

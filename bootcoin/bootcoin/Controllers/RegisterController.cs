using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using bootcoin.Models.Domain;
using bootcoin.Helper;
// using System.Web;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class RegisterController : Controller
    {

        private IConfiguration _config;
        CommonHelper _helper;

        public RegisterController(IConfiguration config)
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
            string UserExistsQuery = $"Select * from Users where Email='{userRegister.Email}'";
            bool userExists = _helper.UserAlreadyExists(UserExistsQuery);
            if (userExists)
            {
                TempData["AlertMessage"] = "User Already Exist!";
                return View("Index");
            }
            var id = Guid.NewGuid();
            string Query = $"Insert into [Users](UserId, Email,Password) values('{id}','{userRegister.Email}','{userRegister.Password}')";
            int result = _helper.DMLTransaction(Query);
            if(result > 0)
            {
                
                TempData["AlertMessage"] =  "Registration successful, please sign in";
                EntryIntoSession(userRegister.Email);
                return View("Index");
            }
            return View("Index");
        }

        private void EntryIntoSession(string email)
        {
            HttpContext.Session.SetString("Email", email);
        }
        
        


    }
}

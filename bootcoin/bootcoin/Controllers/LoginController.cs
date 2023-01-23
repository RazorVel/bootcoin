using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using bootcoin.Models.Domain;
using bootcoin.Models.Login;
using bootcoin.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace bootcoin.Controllers
{

    public class LoginController : Controller
    {
        private readonly BootcoinDbContext bootcoinDbContext;

        public LoginController(BootcoinDbContext bootcoinDbContext)
        {
            this.bootcoinDbContext = bootcoinDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var currentUser = HttpContext.Session.GetString("Email");

            if (currentUser != null)
            {
                var role = HttpContext.Session.GetString("Role");

                if (role == "Admin")
                {
                    return Redirect("/Admin");
                }
                else if (role == "Participant")
                {
                    return Redirect("/Trainee");
                }
            }
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ViewModel request)
        {
            var user = await bootcoinDbContext.Users.FirstOrDefaultAsync((x => x.Email == request.Email && x.Password == request.Password));

            if (user != null)
            {
                //insert user info to session
                //
                //
                var email = HttpContext.Session.GetString("Email");

                if (email == null || email != user.Email)
                {
                    HttpContext.Session.SetString("Email", user.Email);
                    HttpContext.Session.SetString("Name", user.Name);
                    HttpContext.Session.SetString("Role", user.Role);
                }

                if (user.Role == "Participant")
                    return Redirect("/Trainee");
                else if (user.Role == "Admin")
                    return Redirect("/Admin");
            }
            else
            {
                ViewBag.Error = "Wrong email or password.";
            }
            return View();
        }
    }
}

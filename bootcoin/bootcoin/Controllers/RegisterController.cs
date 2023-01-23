using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using bootcoin.Models.Domain;
using bootcoin.Models.Register;
using bootcoin.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
// using System.Web;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class RegisterController : Controller
    {
        private readonly BootcoinDbContext bootcoinDbContext;

        public RegisterController(BootcoinDbContext bootcoinDbContext)
        {
            this.bootcoinDbContext = bootcoinDbContext;
        }

        [HttpGet]
        public IActionResult Index(Object options)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ViewModel request)
        {
            var newUserId = Guid.NewGuid();

            var newUser = new User()
            {
                UserId = newUserId,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                Role = "Participant",
                Balance = 0
            };

            var newProfile = new Profile()
            {
                ProfileId = Guid.NewGuid(),
                UserId = newUserId
            };

            var userExists = await bootcoinDbContext.Users.FirstOrDefaultAsync(x => x.Email == request.Email);

            if (userExists == null) {
                await bootcoinDbContext.Users.AddAsync(newUser);
                await bootcoinDbContext.Profiles.AddAsync(newProfile);
                await bootcoinDbContext.SaveChangesAsync();

                return Redirect("/Login");
            }
            else
            {
                ViewBag.Error = "A user with the same email address already exists.";
                return View() ;
            }
        }
    }
}

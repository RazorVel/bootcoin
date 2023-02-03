using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using bootcoin.Data;
// using System.Web;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class AdminController : Controller
    {
        private readonly BootcoinDbContext bootcoinDbContext;

        public AdminController(BootcoinDbContext bootcoinDbContext)
        {
            this.bootcoinDbContext = bootcoinDbContext;
        }

        public void SessionStart()
        {
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.UserId = HttpContext.Session.GetString("UserId");

        }

        public IActionResult View()
        {
            return View(viewName: "Index");
        }

        public IActionResult View(string? viewName)
        {
            return View(viewName, model: ViewData.Model);
        }

        public IActionResult view(object? model)
        {
            return View(viewName: "Index", model: model);
        }

        public IActionResult View(string? viewName, object? model)
        {
            if (ViewBag.Role == "Admin")
                return base.View(viewName, model);
            else if (ViewBag.Role == "Participant")
                return Redirect("/Trainee");
            else
                return Redirect("/Logout");

        }
        public IActionResult Index()
        {
            SessionStart();

            return View();
        }
        public IActionResult Teams()
        {
            SessionStart();

            return View("~/Views/Admin/Teams.cshtml");
        }
    }
}

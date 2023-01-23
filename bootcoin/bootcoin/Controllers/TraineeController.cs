using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class TraineeController : Controller
    {
        public void SessionStart()
        {
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Role = HttpContext.Session.GetString("Role");

        }

        public ActionResult View()
        {
            return View(viewName: "Index");
        }

        public ActionResult View(string? viewName)
        {
            return View(viewName, model: ViewData.Model);
        }

        public ActionResult view(object? model)
        {
            return View(viewName: "Index", model: model);
        }

        public ActionResult View(string? viewName, object? model)
        {
            if (ViewBag.Role == "Participant")
                return base.View(viewName, model);
            else if (ViewBag.Role == "Admin")
                return Redirect("/Admin");
            else
                return Redirect("/Logout");

        }

        public ActionResult Index()
        {
            SessionStart();
            
            return View ();
        }
        public ActionResult TeamMember()
        {
            SessionStart();

            return View("~/Views/Trainee/TeamMember.cshtml");
        }
        public ActionResult Redeem()
        {
            SessionStart();

            return View("~/Views/Trainee/Redeem.cshtml");
        }
        public ActionResult History()
        {
            SessionStart();

            return View("~/Views/Trainee/History.cshtml");
        }
    }
}

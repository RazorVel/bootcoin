using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
// using System.Web;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class DebugController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View ();
        }
    }
}

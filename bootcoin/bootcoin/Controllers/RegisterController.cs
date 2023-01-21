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
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}

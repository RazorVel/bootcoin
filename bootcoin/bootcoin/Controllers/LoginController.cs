using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using bootcoin.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
// using System.Web;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        
    }
}

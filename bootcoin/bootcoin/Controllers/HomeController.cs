using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
// using System.Web.Mvc;
// using System.Web.Mvc.Ajax;

namespace bootcoin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return Redirect("~/Login");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TeamMember()
        {
            return View("~/Views/Admin/TeamMember.cshtml");
        }
        public ActionResult Redeem()
        {
            return View("~/Views/Admin/Redeem.cshtml");
        }
        public ActionResult History()
        {
            return View("~/Views/Admin/History.cshtml");
        }
    }
}

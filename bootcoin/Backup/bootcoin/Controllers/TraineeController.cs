using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class TraineeController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult TeamMember()
        {
            return View("~/Views/Trainee/TeamMember.cshtml");
        }
        public ActionResult Redeem()
        {
            return View("~/Views/Trainee/Redeem.cshtml");
        }
        public ActionResult History()
        {
            return View("~/Views/Trainee/History.cshtml");
        }
    }
}

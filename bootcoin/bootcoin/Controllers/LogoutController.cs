using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace bootcoin.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();

            return Redirect("/Login");
        }
    }
}

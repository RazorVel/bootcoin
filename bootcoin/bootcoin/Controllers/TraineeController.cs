using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
using Microsoft.EntityFrameworkCore;
using bootcoin.Data;
using bootcoin.Models.Domain;
using bootcoin.Models.Trainee;
// using System.Web.Mvc;

namespace bootcoin.Controllers
{
    public class TraineeController : Controller
    {
        private readonly BootcoinDbContext bootcoinDbContext;

        public TraineeController(BootcoinDbContext bootcoinDbContext)
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
            if (ViewBag.Role == "Participant")
                return base.View(viewName, model);
            else if (ViewBag.Role == "Admin")
                return Redirect("/Admin");
            else
                return Redirect("/Logout");

        }

        public IActionResult Index()
        {
            SessionStart();
            
            return View ();
        }
        public IActionResult TeamMember()
        {
            SessionStart();

            return View("~/Views/Trainee/TeamMember.cshtml");
        }
        public IActionResult Redeem()
        {
            SessionStart();

            return View("~/Views/Trainee/Redeem.cshtml");
        }
        public async Task<IActionResult> History()
        {
            SessionStart();

            string userId = ViewBag.UserId;

            var headers = await bootcoinDbContext.TransactionHeaders.ToListAsync();
            var details = await bootcoinDbContext.TransactionDetails.ToListAsync();

            var transactions = headers.Join(
                details,
                headers => headers.TransactionId,
                details => details.TransactionId,
                (headers, details) => new
                {
                    SourceId = headers.SourceId,
                    TargetId = headers.TargetId,
                    Date = headers.Date,
                    Type = headers.Type,
                    Amount = details.Amount,
                    BalanceAfter = details.BalanceAfter
                }
            );

            transactions = transactions.Where(x => x.SourceId.ToString() == userId || x.TargetId.ToString() == userId);

            List<HistoryViewModel> models = new List<HistoryViewModel>();

            foreach (var record in transactions)
            {
                models.Add(new HistoryViewModel()
                {
                    SourceId = record.SourceId,
                    TargetId = record.TargetId,
                    Date = record.Date,
                    Type = record.Type,
                    Amount = record.Amount,
                    BalanceAfter = record.BalanceAfter
                });
            }

            return View("~/Views/Trainee/History.cshtml", models);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using bootcoin.Data;
using Microsoft.EntityFrameworkCore;
using bootcoin.Models.Admin;
using bootcoin.Models.Domain;
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

        public async Task<IActionResult> SessionStart()
        {
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.UserId = HttpContext.Session.GetString("UserId");

            var userId = HttpContext.Session.GetString("UserId");
            var profiles = await bootcoinDbContext.Profiles.FirstOrDefaultAsync((x => x.UserId.ToString() == userId));

            if (profiles != null)
            {
                ViewBag.Department = profiles.Department;
                ViewBag.Mbti = profiles.Mbti;
                ViewBag.Zodiac = profiles.Zodiac;
                ViewBag.FavoriteFood = profiles.FavoriteFood;
                ViewBag.FunFact = profiles.FunFact;
            }

            return null;
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
        public async Task<IActionResult> Index()
        {
            await SessionStart();

            return View("~/Views/Admin/Index.cshtml");
        }
        public async Task<IActionResult> Teams()
        {
            await SessionStart();

            var users = await bootcoinDbContext.Users.ToListAsync();
            var profiles = await bootcoinDbContext.Profiles.ToListAsync();

            var people = users.Join(
                profiles,
                users => users.UserId,
                profiles => profiles.UserId,
                (users, profiles) => new
                {
                    Email = users.Email,
                    Name = users.Name,
                    Role = users.Role,
                    Balance = users.Balance,
                    Avatar = profiles.Avatar,
                    Department = profiles.Department,
                    Mbti = profiles.Mbti,
                    Zodiac = profiles.Zodiac,
                    FavoriteFood = profiles.FavoriteFood,
                    FunFact = profiles.FunFact
                }
            );

            //filter by team, possible future upgrade
            //people = people.Where(x => x.Team == userTeam);

            people = people.Where(x => x.Role == "Participant");

            List<TeamsViewModel> models = new List<TeamsViewModel>();

            foreach (var person in people)
            {
                models.Add(new TeamsViewModel()
                {
                    Email = person.Email,
                    Name = person.Name,
                    Role = person.Role,
                    Balance = person.Balance,
                    Avatar = person.Avatar,
                    Department = person.Department,
                    Mbti = person.Mbti,
                    Zodiac = person.Zodiac,
                    FavoriteFood = person.FavoriteFood,
                    FunFact = person.FunFact
                });
            }

            return View("~/Views/Admin/Teams.cshtml", models);
        }

        public async Task<IActionResult> InputCoin()
        {
            await SessionStart();

            string email = Request.Form["email"];
            var user = await bootcoinDbContext.Users.FirstOrDefaultAsync(x => x.Email == email);

            int amount;
            try
            {
                amount = Int32.Parse(Request.Form["amount"]);
            }
            catch (FormatException e)
            {
                amount = 0;
            }

            if (user != null)
            {
                if (user.Balance != null)
                    user.Balance = user.Balance + amount;
                else
                    user.Balance = amount;

                Guid transactionId = Guid.NewGuid();

                TransactionHeader newTransactionHeader = new TransactionHeader()
                {
                    TransactionId = transactionId,
                    SourceId = Guid.Parse(ViewBag.UserId),
                    TargetId = user.UserId,
                    Date = DateTime.Now,
                    Type = "Input"
                };

                TransactionDetail newTransactoinDetail = new TransactionDetail()
                {
                    TransactionId = transactionId,
                    Amount = amount,
                    BalanceAfter = (int)user.Balance
                };

                await bootcoinDbContext.TransactionHeaders.AddAsync(newTransactionHeader);
                await bootcoinDbContext.TransactionDetails.AddAsync(newTransactoinDetail);
            }

            bootcoinDbContext.SaveChanges();

            return RedirectToAction("Teams");
        }
    }
}

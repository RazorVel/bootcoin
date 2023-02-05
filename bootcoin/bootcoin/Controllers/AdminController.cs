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
            if (ViewBag.Role == "Admin")
                return base.View(viewName, model);
            else if (ViewBag.Role == "Participant")
                return Redirect("/Trainee");
            else
                return Redirect("/Logout");

        }
        public IActionResult Index()
        {
            SessionStart();

            return View();
        }
        public async Task<IActionResult> Teams()
        {
            SessionStart();

            var users = await bootcoinDbContext.Users.ToListAsync();
            var profiles = await bootcoinDbContext.Profiles.ToListAsync();

            var people = users.Join(
                profiles,
                users => users.UserId,
                profiles => profiles.UserId,
                (users, profiles) => new
                {
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

            List<TeamMemberViewModel> models = new List<TeamMemberViewModel>();

            foreach (var person in people)
            {
                models.Add(new TeamMemberViewModel()
                {
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

        [HttpPost]
        public IActionResult Input(string agentName, int amount)
        {
            if (string.IsNullOrEmpty(agentName) || amount <= 0)
                return BadRequest("Invalid input");

            var targetUser = bootcoinDbContext.Users.Where(u => u.Name == agentName).FirstOrDefault();
            if (targetUser == null)
            {
                return BadRequest("Target user not found");
            }

            SessionStart();
            // Add transaction header
            var transactionHeader = new TransactionHeader
            {
                SourceId = Guid.Parse(ViewBag.UserId),
                TargetId = targetUser.UserId,
                Date = DateTime.Now,
                Type = "Input"
            };
            bootcoinDbContext.TransactionHeaders.Add(transactionHeader);

            // Add transaction detail
            var transactionDetail = new TransactionDetail
            {
                TransactionId = transactionHeader.TransactionId,
                Amount = amount,
                BalanceAfter = 1000
            };
            bootcoinDbContext.TransactionDetails.Add(transactionDetail);

            // Update target user balance
            targetUser.Balance += amount;

            try
            {
                bootcoinDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to process transaction: " + ex.Message);
            }

            return RedirectToAction("Teams");
        }

    }
}

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
using Microsoft.Identity.Client;
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

        public async Task<IActionResult> SessionStart()
        {
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.UserId = HttpContext.Session.GetString("UserId");

            var userId = HttpContext.Session.GetString("UserId");   
            var profiles = await bootcoinDbContext.Profiles.FirstOrDefaultAsync((x => x.UserId.ToString() == userId));

            ViewBag.Department = profiles.Department;
            ViewBag.Mbti = profiles.Mbti;
            ViewBag.Zodiac = profiles.Zodiac;
            ViewBag.FavoriteFood = profiles.FavoriteFood;
            ViewBag.FunFact = profiles.FunFact;

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
            if (ViewBag.Role == "Participant")
                return base.View(viewName, model);
            else if (ViewBag.Role == "Admin")
                return Redirect("/Admin");
            else
                return Redirect("/Logout");
        }

        public async Task<IActionResult> Index()
        {
            await SessionStart();
            
            return View ("~/Views/Trainee/Index.cshtml");
        }
        public async Task<IActionResult> TeamMember()
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

            foreach(var person in people)
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

            return View("~/Views/Trainee/TeamMember.cshtml", models);
        }
        public async Task<IActionResult> Redeem()
        {
            await SessionStart();

            return View("~/Views/Trainee/Redeem.cshtml");
        }
        public async Task<IActionResult> History()
        {
            await SessionStart();

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

        public async Task<IActionResult> updateProfile()
        {
            var userId = HttpContext.Session.GetString("UserId");
            var profile = await bootcoinDbContext.Profiles.FirstOrDefaultAsync(x => x.UserId.ToString() == userId);

            if(profile != null)
            {
                profile.Department = Request.Form["department"];
                profile.Mbti = Request.Form["mbti"];
                profile.Zodiac = Request.Form["zodiac"];
                profile.FavoriteFood = Request.Form["favorite-food"];

                string[] funFacts = { 
                    Request.Form["fun-fact-1"],
                    Request.Form["fun-fact-2"],
                    Request.Form["fun-fact-3"]
                };

                profile.FunFact = String.Join(";", funFacts);

                await bootcoinDbContext.SaveChangesAsync();
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}

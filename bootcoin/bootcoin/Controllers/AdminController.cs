using System;
using System.Collections.Generic;
using System.Linq;
using bootcoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using bootcoin.Data;
using Microsoft.EntityFrameworkCore;
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
    }
}

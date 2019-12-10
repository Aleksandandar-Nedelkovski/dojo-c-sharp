using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BELTEXAM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BELTEXAM.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("register")]
        public IActionResult Register (User newUser) {
            Regex rx = new Regex (@"\d");

            if (newUser.FirstName != null) {
                MatchCollection FirstNameMatches = rx.Matches (newUser.FirstName);
                if (FirstNameMatches.Count != 0) {
                    ModelState.AddModelError ("FirstName", "'Name' Fields cannot contain numeric characters");
                }
            }
            if (newUser.LastName != null) {
                MatchCollection LastNameMatches = rx.Matches (newUser.LastName);
                if (LastNameMatches.Count != 0) {
                    ModelState.AddModelError ("LastName", "'Name' Fields cannot contain numeric characters");
                }
            }
            if (newUser.Password != null) {

                MatchCollection PasswordNumberMatches = rx.Matches (newUser.Password);
                if (PasswordNumberMatches.Count == 0) {
                    ModelState.AddModelError ("Password", "Password should contain at least one number");
                }
                string SpecialChars = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
                bool HasSpecialChars = false;
                foreach (var character in SpecialChars) {
                    if (newUser.Password.Contains (character)) {
                        HasSpecialChars = true;
                    }
                }
                if (!HasSpecialChars) {
                    ModelState.AddModelError ("Password", "Password should contain at least one special character");
                }
            }

            if (dbContext.Users.Any (c => c.Email == newUser.Email)) {
                ModelState.AddModelError ("Email", "That Email is taken");
            }
            if (ModelState.IsValid) {
                PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                newUser.Password = Hasher.HashPassword (newUser, newUser.Password);

                HttpContext.Session.SetString ("UserName", newUser.FirstName + " " + newUser.LastName);
                dbContext.Users.Add (newUser);
                dbContext.SaveChanges ();
                HttpContext.Session.SetInt32 ("ID", newUser.UserId);
                return Redirect ("home");
            }
            return View ("Index");
        }

        [HttpPost ("login")]
        public IActionResult Login (Login _logUSer) {
            User DbUser = dbContext.Users.FirstOrDefault (c => c.Email == _logUSer.EmailLogin);
            if (DbUser == null) {
                ModelState.AddModelError ("LoginEmail", "Email not found. Register?");
            }
            if (ModelState.IsValid) {
                var hasher = new PasswordHasher<Login> ();
                var result = hasher.VerifyHashedPassword (_logUSer, DbUser.Password, _logUSer.PasswordLogin);
                if (result == 0) {
                    ModelState.AddModelError ("LoginEmail", "Email or password not valid");
                    return View ("Index");
                }
                HttpContext.Session.SetInt32 ("ID", DbUser.UserId);
                HttpContext.Session.SetString ("UserName", DbUser.FirstName + " " + DbUser.LastName);
                return Redirect ("home");
            }
            return View ("Index");
        }

        [HttpGet ("logout")]
        public IActionResult LogOut () {
            HttpContext.Session.Clear ();
            return Redirect ("/");
        }

        [HttpGet ("home")]
        public IActionResult Home () {
            if (HttpContext.Session.GetInt32 ("ID") == null) {
                return Redirect ("/");
            }
            List<Event> Events = dbContext.Events
                .Include (u => u.Participants)
                .ThenInclude (u => u.User)
                .Include (e => e.Coordinator)
                .ToList ();
            ViewBag.Events = Events;
            int? seshUser = HttpContext.Session.GetInt32 ("ID");

            List<Participant> yourEvents = dbContext.Participants
                .Where (p => p.UserID == (int) seshUser)
                .Include (p => p.Event)
                .ToList ();
            ViewBag.EventsWithConflicts = yourEvents;
            return View ();
        }
    }
}
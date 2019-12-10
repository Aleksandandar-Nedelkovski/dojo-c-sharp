using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("")]
        public IActionResult LogIn (Login logUser) {
            User LogUser = dbContext.Users.FirstOrDefault (u => u.Email == logUser.EmailLogin);
            if (LogUser == null) {
                ModelState.AddModelError ("EmailLogin", "That Email Dosn't Exist!");
            }

            if (ModelState.IsValid) {
                var hasher = new PasswordHasher<Login> ();
                var result = hasher.VerifyHashedPassword (logUser, LogUser.Password, logUser.PasswordLogin);
                if (result == 0) {
                    ModelState.AddModelError ("PasswordLogin", "Email or Password incorrect");
                    return View ("Index");
                }
                HttpContext.Session.SetInt32 ("ID", LogUser.UserId);
                return Redirect ("dashboard");
            }
            return View ("Index");
        }

        [HttpGet ("register")]
        public IActionResult RegisterView () {
            return View ();
        }

        [HttpPost ("register")]
        public IActionResult Register (User newUser) {
            if (dbContext.Users.Any (u => u.Email == newUser.Email)) {
                ModelState.AddModelError ("Email", "Taken!");
            }
            if (ModelState.IsValid) {
                PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                newUser.Password = Hasher.HashPassword (newUser, newUser.Password);
                dbContext.Add (newUser);
                dbContext.SaveChanges ();
                HttpContext.Session.SetInt32 ("ID", newUser.UserId);
                Console.WriteLine ("===================================");
                Console.WriteLine (HttpContext.Session.GetInt32 ("ID"));
                return Redirect ("/dashboard");
            }
            return View ("Index");
        }

        [HttpGet ("dashboard")]
        public IActionResult DashBoard () {
            int? seshUser = HttpContext.Session.GetInt32 ("ID");
            if (seshUser == null) {
                return Redirect ("/");
            }
            seshUser = (int) seshUser;
            string UserName = dbContext.Users.FirstOrDefault (u => u.UserId == seshUser).FirstName.ToString ();
            HttpContext.Session.SetString ("UserName", UserName);
            List<Wedding> weddings = dbContext.Weddings
                .Include (w => w.RSVPs)
                .ThenInclude (g => g.User)
                .ToList ();
            return View (weddings);
        }

        [HttpGet ("newwedding")]
        public IActionResult NewWedding () {
            if (HttpContext.Session.GetInt32 ("ID") == null) {
                return Redirect ("/");
            }
            return View ();
        }

        [HttpPost ("newwedding")]
        public IActionResult AddWedding (Wedding newWedding) {
            if (DateTime.Today.Date > newWedding.When.Date) {
                ModelState.AddModelError ("When", "Date must be in the future");
            }
            if (ModelState.IsValid) {
                int? seshUser = HttpContext.Session.GetInt32 ("ID");
                newWedding.CreatorID = (int) seshUser;
                dbContext.Weddings.Add (newWedding);
                dbContext.SaveChanges ();
                return Redirect ($"wedding/{newWedding.WeddingID}");
            }
            return View ("NewWedding");
        }

        [HttpGet ("delete/{weddingID}")]
        public IActionResult Divorce (int weddingID) {
            if (HttpContext.Session.GetInt32 ("ID") == null) {
                return Redirect ("/");
            }
            Wedding thisWedding = dbContext.Weddings.FirstOrDefault (w => w.WeddingID == weddingID);
            dbContext.Remove (thisWedding);
            dbContext.SaveChanges ();
            return Redirect ("/dashboard");
        }

        [HttpGet ("wedding/{weddingID}")]
        public IActionResult ViewWedding (int weddingID) {
            if (HttpContext.Session.GetInt32 ("ID") == null) {
                return Redirect ("/");
            }
            var thisWedding = dbContext.Weddings
                .Include (w => w.RSVPs)
                .ThenInclude (g => g.User)
                .FirstOrDefault (w => w.WeddingID == weddingID);
            return View (thisWedding);
        }

        [HttpGet ("logout")]
        public IActionResult LogOut () {
            HttpContext.Session.Clear ();
            return Redirect ("/");
        }

        [HttpGet ("RSVP/{weddingID}")]
        public IActionResult RSVPToWedding (int weddingID) {
            if (HttpContext.Session.GetInt32 ("ID") == null) {
                return Redirect ("/");
            }
            int? seshUser = HttpContext.Session.GetInt32 ("ID");
            RSVP newRSVP = new RSVP ();
            newRSVP.WeddingId = weddingID;
            newRSVP.UserId = (int) seshUser;
            dbContext.RSVPs.Add (newRSVP);
            dbContext.SaveChanges ();
            return Redirect ("/dashboard");
        }

        [HttpGet ("UnRSVP/{weddingID}")]
        public IActionResult UnRSVPFromWedding (int weddingID) {
            if (HttpContext.Session.GetInt32 ("ID") == null) {
                return Redirect ("/");
            }
            int? seshUser = HttpContext.Session.GetInt32 ("ID");
            RSVP thisRSVP;
            List<RSVP> weddingRSVP = dbContext.RSVPs
                .Where (w => w.WeddingId == weddingID).ToList ();
            foreach (var RSVP in weddingRSVP) {
                if (RSVP.UserId == (int) seshUser) {
                    thisRSVP = RSVP;
                    dbContext.RSVPs.Remove (thisRSVP);
                    dbContext.SaveChanges ();
                }
            }
            return Redirect ("/dashboard");
        }
    }
}
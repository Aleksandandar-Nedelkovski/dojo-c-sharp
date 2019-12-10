using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginReg.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }
        public IActionResult Index () {
            List<User> AllUsers = dbContext.LoginAndReg.ToList ();
            return View ();
        }

        [HttpGet ("login")]
        public IActionResult Loginn () {
            return View ("Login");
        }

        [HttpGet ("register")]
        public IActionResult Register () {
            List<User> AllUsers = dbContext.LoginAndReg.ToList ();
            return View ("Index");
        }

        [HttpGet ("success")]
        public IActionResult Success () {
            if (HttpContext.Session.GetInt32 ("UserID") == null) {
                return View ("Login");
            }
            List<User> AllUsers = dbContext.LoginAndReg.ToList ();
            int UserID = (int) HttpContext.Session.GetInt32 ("UserID");
            User SignedIn = dbContext.LoginAndReg.FirstOrDefault (u => u.Id == UserID);
            return View ("Success", SignedIn);
        }

        [HttpPost ("register")]
        public IActionResult Register (User newUser) {
            if (ModelState.IsValid) {
                if (dbContext.LoginAndReg.Any (u => u.Email == newUser.Email)) {
                    ModelState.AddModelError ("Email", "Email already in use!");
                    return View ("Index");
                } else {
                    PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                    newUser.Password = Hasher.HashPassword (newUser, newUser.Password);
                    dbContext.Add (newUser);
                    dbContext.SaveChanges ();
                    HttpContext.Session.SetInt32 ("UserID", newUser.Id);
                    Console.WriteLine ("===================================");
                    Console.WriteLine (HttpContext.Session.GetInt32 ("UserID"));
                    return RedirectToAction ("Success");
                }
            }
            return View ("Index");
        }

        [HttpPost ("Login")]
        public IActionResult Login (LoginUser userSubmission) {
            if (ModelState.IsValid) {
                var userInDb = dbContext.LoginAndReg.FirstOrDefault (u => u.Email == userSubmission.Email);
                if (userInDb == null) {
                    ModelState.AddModelError ("Email", "Invalid Email/Password");
                    return View ("Login");
                }
                var hasher = new PasswordHasher<LoginUser> ();
                var result = hasher.VerifyHashedPassword (userSubmission, userInDb.Password, userSubmission.Password);
                if (result == 0) {
                    return View ("Login");
                }
                HttpContext.Session.SetInt32 ("UserID", userInDb.Id);
                return RedirectToAction ("Success");
            }
            return View ("Index");
        }

        [HttpGet ("Logout")]
        public IActionResult Logout () {
            HttpContext.Session.Clear ();
            return View ("Index");
        }
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
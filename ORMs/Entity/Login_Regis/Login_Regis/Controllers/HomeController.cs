using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Login_Regis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login_Regis.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet]
        [Route ("")]
        public IActionResult Index () {
            List<User> AllUsers = dbContext.Users.ToList ();
            return View ();
        }

        [HttpGet]
        [Route ("Result")]
        public IActionResult ResultMatch () {
            if (HttpContext.Session.GetInt32 ("UserID") == null) {
                return View ("Login");
            }
            List<User> AllUsers = dbContext.Users.ToList ();

            int UserID = (int) HttpContext.Session.GetInt32 ("UserID");
            User SignedIn = dbContext.Users.FirstOrDefault (u => u.UserId == UserID); 
            return View ("Result", SignedIn);
        }

        [HttpPost]
        [Route ("Register")]
        public IActionResult Register (User newUser) {
            if (ModelState.IsValid) {
                if (dbContext.Users.Any (u => u.Email == newUser.Email)) {
                    ModelState.AddModelError ("Email", "Email already in use!");
                    return View ("Index");
                } else {
                    PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                    newUser.Password = Hasher.HashPassword (newUser, newUser.Password);
                    dbContext.Add (newUser);
                    dbContext.SaveChanges ();
                    HttpContext.Session.SetInt32 ("UserID", newUser.UserId);
                    return RedirectToAction ("ResultMatch");
                }
            }
            return View ("Index");

        }

        // logic code for link button wich render register page from login
        [HttpGet]
        [Route ("Register")]
        public IActionResult Register () {
            List<User> AllUsers = dbContext.Users.ToList ();
            Console.WriteLine ("-------678564--------");
            return View ("Index");
        }

        [HttpGet]
        [Route ("Login")]
        public IActionResult Login () {
            List<User> AllUsers = dbContext.Users.ToList ();
            Console.WriteLine ("-------678564--------");
            return View ("Login");
        }

        [HttpPost]
        [Route ("LoginPost")]
        public IActionResult LoginPost (Login userSubmission) {
            Console.WriteLine ("------1-------");
            if (ModelState.IsValid) {
                Console.WriteLine ("--------2--------");
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault (u => u.Email == userSubmission.Email);
                // If no user exists with provided email
                if (userInDb == null) {
                    Console.WriteLine ("-----------3-----------");
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError ("Email", "Invalid Email/Password");
                    return View ("Login");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<Login> ();

                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword (userSubmission, userInDb.Password, userSubmission.Password);

                // result can be compared to 0 for failure
                if (result == 0) {
                    Console.WriteLine ("-------4-----------");
                    // handle failure (this should be similar to how "existing email" is handled)

                    return View ("Login");
                }
                Console.WriteLine ("------------5----------");
                HttpContext.Session.SetInt32 ("UserID", userInDb.UserId);
                return RedirectToAction ("ResultMatch");
            }
            Console.WriteLine ("-------------6------------");
            return View ("Login");

        }

        [HttpGet]
        [Route ("Logout")]
        public IActionResult Logout () {
            HttpContext.Session.Clear ();

            return View ("Login");
        }

    }
}
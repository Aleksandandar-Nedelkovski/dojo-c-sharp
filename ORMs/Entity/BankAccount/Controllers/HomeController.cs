using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BankAccount.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            return View ("Register");
        }

        [HttpGet ("login")]
        public IActionResult Login () {
            return View ("Login");
        }

        [HttpPost ("register")]
        public IActionResult Register (User newUser) {
            if (ModelState.IsValid) {
                if (dbContext.Users.Any (u => u.Email == newUser.Email)) {
                    ModelState.AddModelError ("Email", "Email already in use!");
                    return View ("Register");
                } else {
                    PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                    newUser.Password = Hasher.HashPassword (newUser, newUser.Password);
                    dbContext.Add (newUser);
                    dbContext.SaveChanges ();
                    HttpContext.Session.SetInt32 ("UserID", newUser.UserId);
                    Console.WriteLine ("===================================");
                    Console.WriteLine (HttpContext.Session.GetInt32 ("UserID"));
                    return RedirectToAction ("Success");
                }
            }
            return View ("Register");
        }

        [HttpPost ("Login")]
        public IActionResult Login (LoginUser userSubmission) {
            if (ModelState.IsValid) {
                var userInDb = dbContext.Users.FirstOrDefault (u => u.Email == userSubmission.Email);
                if (userInDb == null) {
                    ModelState.AddModelError ("Email", "Invalid Email");
                    return View ("Login");
                }
                var hasher = new PasswordHasher<LoginUser> ();
                var result = hasher.VerifyHashedPassword (userSubmission, userInDb.Password, userSubmission.Password);
                if (result == 0) {
                    ModelState.AddModelError ("Password", "Invalid Password");
                    return View ("Login");
                }
                User loggedUser = userInDb;
                HttpContext.Session.SetInt32 ("logged", loggedUser.UserId);
                return RedirectToAction ("Success");
            }
            return View ("Register");
        }

        [HttpGet ("Logout")]
        public IActionResult Logout () {
            HttpContext.Session.Clear ();
            return View ("Register");
        }

        [HttpGet ("success")]
        public IActionResult Success (int id) {
            if (HttpContext.Session.GetInt32 ("logged") == null) {
                return View ("Login");
            }
            PopulateBag ();
            return View ("Success");
        }

        [HttpPost ("deposit")]
        public IActionResult Deposit (Transaction userSubmission) {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("logged"));
            if (loggedUser.Balance + userSubmission.Amount < 0) {
                System.Console.WriteLine (loggedUser.Balance);
                TempData["alertMessage"] = "<p style='color:red;'>The amount you enter is invalid.</p>";
                return RedirectToAction ("success");
            }
            userSubmission.UserId = loggedUser.UserId;
            userSubmission.AccountHolder = loggedUser;
            userSubmission.AmountString = userSubmission.Amount.ToString ("$0.00");
            userSubmission.CreatedAtString = userSubmission.CreatedAt.ToString (("MMMM dd, yyyy"));
            dbContext.Add (userSubmission);
            dbContext.SaveChanges ();
            CalculateBalance (userSubmission.Amount);
            PopulateBag ();
            return RedirectToAction ("success");
        }
        public void CalculateBalance (double amount) {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("logged"));
            loggedUser.Balance += amount;
            dbContext.SaveChanges ();
        }

        public void PopulateBag () {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("logged"));
            List<Transaction> transactionsWithUser = dbContext.Transactions
                .Where (p => p.UserId == loggedUser.UserId)
                .Include (t => t.AccountHolder)
                .ToList ();
            transactionsWithUser.Reverse ();
            ViewBag.UsersTransactions = transactionsWithUser;
            ViewBag.FirstName = loggedUser.FirstName;
            ViewBag.LastName = loggedUser.LastName;
            ViewBag.UserBalance = loggedUser.Balance.ToString ("0.00");
        }
    }
}
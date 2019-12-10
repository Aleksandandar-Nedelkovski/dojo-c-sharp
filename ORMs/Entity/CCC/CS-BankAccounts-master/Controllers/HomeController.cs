using System;
using System.Collections.Generic;
using System.Linq;
using BankAccounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers {
    public class HomeController : Controller {

        private BankAccountsContext dbContext;

        public HomeController (BankAccountsContext context) {
            dbContext = context;
        }

        [HttpGet]
        [Route ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpGet]
        [Route ("register")]
        public IActionResult Register () {
            return View ("Register");
        }

        [HttpPost]
        [Route ("processregister")]
        public IActionResult ProcessRegister (User newUser) {
            if (ModelState.IsValid) {
                if (dbContext.Users.Any (u => u.Email == newUser.Email)) {
                    ModelState.AddModelError ("Email",
                        "Email already in use. Please log in.");
                    return View ("Register");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                newUser.Password = Hasher.HashPassword (newUser, newUser.Password);
                dbContext.Add (newUser);
                dbContext.SaveChanges ();
                User loggedUser = dbContext.Users.FirstOrDefault ((u => u.Email == newUser.Email));
                HttpContext.Session.SetInt32 ("logged", loggedUser.Id);
                return RedirectToAction ("TransactionHistory", loggedUser.Id);
            } else {
                return View ("Register");
            }
        }

        [HttpPost]
        [Route ("processlogin")]
        public IActionResult ProcessLogin (LoginUser userSubmission) {
            if (ModelState.IsValid) {
                var userInDb = dbContext.Users.FirstOrDefault (u => u.Email == userSubmission.Email);
                if (userInDb == null) {
                    ModelState.AddModelError ("Email", "Invalid Email");
                    return View ("Index");
                }

                var hasher = new PasswordHasher<LoginUser> ();
                var result = hasher.VerifyHashedPassword (userSubmission, userInDb.Password, userSubmission.Password);
                if (result == 0) {
                    ModelState.AddModelError ("Password", "Invalid Password");
                    return View ("Index");
                }
                User loggedUser = userInDb;
                HttpContext.Session.SetInt32 ("logged", loggedUser.Id);
                return RedirectToAction ("TransactionHistory");
            } else {
                return View ("Index");
            }
        }

        [HttpGet ("account")]
        public IActionResult TransactionHistory () {
            if (HttpContext.Session.GetInt32("logged") == null) {
                return View ("Index");
            }
            PopulateBag();
            return View ("TransactionHistory");
        }

        [HttpPost]
        [Route ("processtransaction")]
        public IActionResult ProcessTransaction (Transaction userSubmission) {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.Id == HttpContext.Session.GetInt32 ("logged"));
            if (loggedUser.Balance + userSubmission.Amount < 0) {
                System.Console.WriteLine(loggedUser.Balance);
                TempData["alertMessage"] = "<p style='color:red;'>Amount entered is invalid.</p>";
                return RedirectToAction ("TransactionHistory");
            }
            userSubmission.UserId = loggedUser.Id;
            userSubmission.AccountHolder = loggedUser;
            userSubmission.AmountString = userSubmission.Amount.ToString("$0.00");
            userSubmission.CreatedAtString = userSubmission.CreatedAt.ToString(("MMMM dd, yyyy"));
            dbContext.Add (userSubmission);
            dbContext.SaveChanges ();
            CalculateBalance(userSubmission.Amount);
            PopulateBag();
            return RedirectToAction ("TransactionHistory");
        }

        [HttpGet]
        [Route ("logout")]
        public IActionResult Logout (){
            HttpContext.Session.Clear();
            return View("Index");
        }
        public void CalculateBalance (double amount) {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.Id == HttpContext.Session.GetInt32 ("logged"));
            loggedUser.Balance += amount;
            dbContext.SaveChanges ();
        }

        public void PopulateBag() {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.Id == HttpContext.Session.GetInt32 ("logged"));
            List<Transaction> transactionsWithUser = dbContext.Transactions
                .Where(p => p.UserId == loggedUser.Id)
                .Include (t => t.AccountHolder)
                .ToList ();
            transactionsWithUser.Reverse();
            ViewBag.UsersTransactions = transactionsWithUser;
            ViewBag.FirstName = loggedUser.FirstName;
            ViewBag.LastName = loggedUser.LastName;
            ViewBag.UserBalance = loggedUser.Balance.ToString ("0.00");
        }
    }
}
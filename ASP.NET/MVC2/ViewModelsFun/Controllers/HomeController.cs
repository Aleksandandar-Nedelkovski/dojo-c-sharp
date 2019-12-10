using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelsFun.Models;

namespace ViewModelsFun.Controllers {
    public class HomeController : Controller {
        public List<User> GenerateUsers () {
            return new List<User> () {
                new User () { FirstName = "Alex", LastName = "Nedelkovski" },
                    new User () { FirstName = "Steve", LastName = "Jobs" },
                    new User () { FirstName = "Bryan", LastName = "Blanca" },
                    new User () { FirstName = "Kirill", LastName = "Yantikov" },
            };
        }

        [Route ("")]
        [HttpGet]
        public IActionResult Index () {
            string stringModel = "My message is here, this is a simple string that I am using as a model";
            return View ("Index", stringModel);
        }

        [Route ("numbers")]
        [HttpGet]
        public IActionResult Numbers () {
            int[] numbers = new int[] { 1, 2, 3, 4, 7, 99, -9 };
            return View (numbers);
        }

        [Route ("users")]
        [HttpGet]
        public IActionResult Users () {
            var users = GenerateUsers ();
            return View (users);
        }

        [Route ("user")]
        [HttpGet]
        public IActionResult User () {
            var rand = new Random();
            var users = GenerateUsers();
            var user = users[rand.Next(users.Count)];
            return View (user);
        }
    }
}
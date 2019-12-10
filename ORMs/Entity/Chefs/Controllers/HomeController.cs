using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Chefs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chefs.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            List<Chef> AllChefs = dbContext.Chefs.ToList ();
            ViewBag.allChefs = AllChefs;
            return View ("Chefs");
        }

        [HttpGet ("alldishes")]
        public IActionResult Dishes () {
            List<Dish> AllDishes = dbContext.Dishes.ToList ();
            ViewBag.allDishes = AllDishes;
            return View ("Dishes");
        }

        [HttpGet ("newchef")]
        public IActionResult NewChef () {
            return View ("NewChef");
        }

        [HttpPost ("create")]
        public IActionResult CreateDish (Dish newDish) {
            Dish addDish = newDish;
            addDish.Creator = dbContext.Chefs.FirstOrDefault (chef => chef.ChefId == newDish.ChefId);
            dbContext.Add (addDish);
            dbContext.SaveChanges ();
            return RedirectToAction ("Dishes");
        }

        [HttpGet ("dishes/new")]
        public IActionResult NewDish () {
            List<Chef> AllChefs = dbContext.Chefs.Include (a => a.CreatedDishes).ToList ();
            IEnumerable<Chef> listOfChef = AllChefs.OrderByDescending (chef => chef.ChefId);
            ViewBag.chef = listOfChef;
            return View ();
        }

        [HttpPost ("registerchef")]
        public IActionResult CreateChef (Chef newChef) {
            if (ModelState.IsValid) {
                if (dbContext.Chefs.Any (c => c.ChefId == newChef.ChefId)) {
                    ModelState.AddModelError ("Chief", "Chef already exist!");
                    return View ("NewChef");
                } else {
                    dbContext.Add (newChef);
                    dbContext.SaveChanges ();
                    return RedirectToAction ("Chefs");
                }
            }
            return View ();
        }
    }
}
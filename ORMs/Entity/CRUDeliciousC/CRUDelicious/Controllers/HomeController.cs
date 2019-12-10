using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers 
{
    public class HomeController : Controller 
    {
        private CRUDcontext dbContext;
        public HomeController (CRUDcontext context) 
        {
            dbContext = context;
        }

        // ROUTES:
        [HttpGet("")]
        public IActionResult Index () 
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList ();
            ViewBag.allDishes = AllDishes;
            return View ();
        }

        [HttpGet("all")]
        public IActionResult All () 
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList ();
            ViewBag.allDishes = AllDishes;
            return View ();
        }

        [HttpGet("new")]
        public IActionResult New () 
        {
            return View ("New");
        }

        [HttpPost("create")]
        public IActionResult Create (Dish dish) 
        {
            if (ModelState.IsValid) {
                Dish newDish = new Dish {
                    Name = dish.Name,
                    Chef = dish.Chef,
                    Tastiness = dish.Tastiness,
                    Calories = dish.Calories,
                    Description = dish.Description
                };
                dbContext.Add (newDish);
                dbContext.SaveChanges ();
                return RedirectToAction ("All");
            } 
            else 
            {
                return View ("New");
            }
        }

        [HttpGet("{id}")]
        public IActionResult DishId (int id) 
        {
            List<Dish> OneDish = dbContext.Dishes.Where (dish => dish.DishId == id).ToList ();
            ViewBag.OneDish = OneDish;
            ViewBag.DishId = id;
            return View ("ViewDish");
        }

        [HttpGet("{id}/show")]
        public IActionResult Show (int id) 
        {
            Dish DishToShow = dbContext.Dishes.FirstOrDefault (dish => dish.DishId == id);
            ViewBag.OneDish = DishToShow;
            return View ("Edit");
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit (int id, Dish editDish) 
        {
            Dish DishToEdit = dbContext.Dishes.FirstOrDefault (dish => dish.DishId == id);
            ViewBag.OneDish = DishToEdit;
            if (ModelState.IsValid)
            {
                DishToEdit.Name = editDish.Name;
                DishToEdit.Chef = editDish.Chef;
                DishToEdit.Tastiness = editDish.Tastiness;
                DishToEdit.Calories = editDish.Calories;
                DishToEdit.Description = editDish.Description;

                dbContext.SaveChanges ();
                return RedirectToAction ("All");
            } 
            else 
            {
                return View ("Edit");
            }
        }

        [HttpGet("{id}/delete")]
        public IActionResult Delete (int id) 
        {
            Dish DishToDelete = dbContext.Dishes.SingleOrDefault (dish => dish.DishId == id);
            dbContext.Dishes.Remove (DishToDelete);
            dbContext.SaveChanges ();
            return RedirectToAction ("All");
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
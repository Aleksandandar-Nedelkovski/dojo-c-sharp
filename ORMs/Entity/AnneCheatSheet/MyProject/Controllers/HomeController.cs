using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController (MyContext context) {
            dbContext = context;
        }
        public IActionResult Index () {
            MyModel new_model_item = new MyModel ();

            new_model_item.Id = 1;
            new_model_item.Data = "Example data.";

            dbContext.Add (new_model_item);
            dbContext.SaveChanges ();

            MyModel saved_item = dbContext.MyModels.FirstOrDefault ();

            Console.WriteLine ($"New item Id: {saved_item.Id}");
            Console.WriteLine ($"New item Data: {saved_item.Data}");
            Console.WriteLine ($"New item CreatedAt: {saved_item.CreatedAt}");
            return View ();
        }

        public IActionResult About () {
            ViewData["Message"] = "Your application description page.";

            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";

            return View ();
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidatingFormSubmission.Models;

namespace ValidatingFormSubmission.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("survey")]
        public IActionResult Survey (User user) {
            Console.WriteLine ("got to survey");
            if (ModelState.IsValid) {
                // do somethng!  maybe insert into db?  then we will redirect
                Console.WriteLine ("valid");
                User newUser = user;
                return View (newUser);

            } else {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                Console.WriteLine ("invalid");
                return View ("Index");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers {
    public class HomeController : Controller {

        [Route ("")]
        [HttpGet]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("survey")]
        public IActionResult Survey (Survey survey) {
            if (ModelState.IsValid) {
                Console.WriteLine ("valid");
                Survey newSurvey = survey;
                return View (newSurvey);
            } else {
                Console.WriteLine ("invalid");
                return View ("Index");
            }
        }

    }
}
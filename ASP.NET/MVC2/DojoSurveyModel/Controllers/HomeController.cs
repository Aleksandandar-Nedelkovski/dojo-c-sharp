using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DojoSurveyModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyModel.Controllers {
    public class HomeController : Controller 
    {
        [Route ("")]
        [HttpGet]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("survey")]
        public IActionResult Submission (Survey survey) {
            Survey newSurvey = survey;
            return View (newSurvey);
        }
    }
}
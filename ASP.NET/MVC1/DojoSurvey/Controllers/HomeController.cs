using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey {
    public class HomeController : Controller {
        //Requests
        //localhost:5000/
        [HttpGet]
        [Route ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        [Route ("process")]
        public IActionResult Method (string name, string location, string language, string comments ) {
            // Do something with form input
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comments = comments;
            return View ("result");
        }
    }
}
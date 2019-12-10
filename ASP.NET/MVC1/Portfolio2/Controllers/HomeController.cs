using Microsoft.AspNetCore.Mvc;

namespace Portfolio2 {
    public class HomeController : Controller {
        //Requests
        //localhost:5000/
        [HttpGet]
        [Route ("")]
        public ViewResult Index () {
            return View ();
        }

        //localhost:5000/projects
        [HttpGet]
        [Route ("projects")]
        public ViewResult Projects () {
            return View("projects");
        }

        //localhost:5000/contact
        [HttpGet]
        [Route ("contact")]
        public ViewResult Contact () {
            return View("contact");
        }
    }
}
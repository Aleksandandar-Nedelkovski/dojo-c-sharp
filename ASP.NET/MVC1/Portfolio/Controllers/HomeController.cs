using Microsoft.AspNetCore.Mvc;

namespace Portfolio {
    public class HomeController : Controller {
        //Requests
        //localhost:5000/
        [Route ("")]
        [HttpGet]
        public string Index () {
            return "This is my index";
        }

        //localhost:5000/projects
        [Route ("projects")]
        [HttpGet]
        public string Projects () {
            return "These are my projects";
        }

        //localhost:5000/contact
        [Route ("contact")]
        [HttpGet]
        public string Contact () {
            return "This is my Contact!";
        }

    }
}
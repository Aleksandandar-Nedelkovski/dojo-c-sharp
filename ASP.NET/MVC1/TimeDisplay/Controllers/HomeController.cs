using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay {
    public class HomeController : Controller {
        //Requests
        //localhost:5000/
        [HttpGet]
        [Route ("")]
        public ViewResult Index () {
            return View ();
        }
    }
}
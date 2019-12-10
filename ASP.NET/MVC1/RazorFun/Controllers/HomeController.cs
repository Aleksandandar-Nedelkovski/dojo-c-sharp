using Microsoft.AspNetCore.Mvc;

namespace RazorFun {
    public class HomeController : Controller {
        //localhost:5000/
        [HttpGet]
        [Route ("")]
        public ViewResult Index () {
            return View ();
        }
    }
}
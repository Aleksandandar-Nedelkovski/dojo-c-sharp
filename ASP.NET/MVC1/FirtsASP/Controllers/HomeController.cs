using Microsoft.AspNetCore.Mvc;

namespace FirtsASP {
    public class HomeController : Controller {
        //Requests
        //localhost:5000/
        [Route ("")]
        [HttpGet]
        public string Index()
        {
            return "Hello From Controller";
        }

        //localhost:5000/hello
        [Route ("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hello Againg";
        }

    }
}
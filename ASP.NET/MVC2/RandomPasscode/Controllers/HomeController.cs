using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers {
    public class HomeController : Controller {
        [Route ("")]
        [HttpGet]
        public IActionResult Index () {
            if (HttpContext.Session.GetInt32 ("Counter") == null); {
                HttpContext.Session.SetInt32 ("Counter", 0);
            }
            ViewBag.count = HttpContext.Session.GetInt32 ("Counter");
            Random rand = new Random ();
            string lett = "";
            List<string> letters = new List<string> () { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (var i = 0; i < 15; i++) {
                lett += letters[rand.Next (0, 61)];
            }
            ViewBag.passcode = lett;
            return View ();
        }

        [HttpPost ("")]
        public IActionResult Count () {
            HttpContext.Session.SetInt32 ("Counter", (int) HttpContext.Session.GetInt32 ("Counter") + 1);
            return RedirectToAction ("Index");
        }

        [HttpPost ("clear")]
        public IActionResult Clear () {
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index");
        }
    }
}
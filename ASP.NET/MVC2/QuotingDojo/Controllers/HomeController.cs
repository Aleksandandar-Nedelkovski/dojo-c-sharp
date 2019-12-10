using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DbConnection;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers {
    public class HomeController : Controller {
        [Route ("")]
        [HttpGet]
        public IActionResult Index () 
        {
            ViewBag.AllQuotes = DbConnector.Query ("SELECT * FROM quotes");
            return View ("Index");
        }

        [HttpPost ("create")]
        public IActionResult Create (Quote quote_from_form) {
            if (ModelState.IsValid) 
            {
                DbConnector.Query ($"INSERT INTO quotes (name, content) VALUES ('{quote_from_form.Name}','{quote_from_form.Content}');");
                return RedirectToAction ("Index");
            } else 
            {
                ViewBag.AllQuotes = DbConnector.Query ("SELECT * FROM quotes");
                return View ("Index");
            }
        }
    }
}
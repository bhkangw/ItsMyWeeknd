using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ItsMyWeeknd.Models;

namespace ItsMyWeeknd.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // List<Person> AllUsers = _context.Users.ToList();
            return View();
        }

        // [HttpGet]
        // [Route("widget")]
        // public IActionResult Widget()
        // {
        //     // List<Person> AllUsers = _context.Users.ToList();
        //     return View("Widget");
        // }

        [HttpPost]
        [Route("search")]
        public IActionResult Search(string Destination)
        {
            if(ModelState.IsValid)
            {
                string url = "http://api.eventful.com/json/events/search?app_key=$WQ2hJfvj4sjx6jpr&l=${Destination}&t=This+Weekend";
                return View("Results");
            }
            return View("Index");
        }
    }
}

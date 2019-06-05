using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab_90_MVC_CORE.Models;

namespace lab_90_MVC_CORE.Controllers
{
    public class HomeController : Controller
    {
        List<string> MainList = new List<string>();
        public IActionResult Index()
        {
            var instance = new ListClass();
            instance.list.Add("This is");
            instance.list.Add("Using a Class");
            MainList.Add("One");
            MainList.Add("Two");
            ViewBag.PageList = MainList;
            return View("Contact", instance); // view is automatically set to index but can be changed by entering in the page name 
                                // eg "Contact"
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

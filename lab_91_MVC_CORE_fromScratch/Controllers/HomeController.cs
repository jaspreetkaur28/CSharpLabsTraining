using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab_91_MVC_CORE_fromScratch.Models;

namespace lab_91_MVC_CORE_fromScratch.Controllers
{
    public class HomeController : Controller
    {
        List<String> ThisList = new List<string>();
        public IActionResult Index()
        {
            ThisList.Add("Hello");
            ThisList.Add("Bye");
            ViewBag.ThisList = ThisList;

            var instance = new TwoProperties();
            instance.List1.Add("List 1 Data"); 
            instance.List1.Add("List 1 Data again"); 
            instance.List1.Add("List 1 more Data "); 

            instance.List2.Add("List 2 Data"); 
            instance.List2.Add("List 2 Data again"); 
            instance.List2.Add("List 2 more Data "); 

            return View("MyPage", instance );
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

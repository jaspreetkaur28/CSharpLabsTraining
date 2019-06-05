using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hw_112_MVC_lab91.Models;

namespace hw_112_MVC_lab91.Controllers
{
    public class HomeController : Controller
    {
        List<string> thislist = new List<string>();


        public List<Customer> customers = new List<Customer>();


        private Northwind db;
        public HomeController(Northwind InjectedContext)
        {
            db = InjectedContext;
        }

        public Customer Customer { get; set; }
        public IActionResult NewPage()
        {

            customers = db.Customers.ToList();
            ViewBag.customers = customers;
            return View();

        }


        public IActionResult Index()
        {

            //thislist.Add("one data is okay");
            //ViewBag.thislist = thislist;
            //var instance = new ClassList();
            //instance.LIST1.Add("this");
            //instance.LIST1.Add("that");
            //instance.LIST1.Add("what");
            //instance.LIST1.Add("no");


            //instance.LIST2.Add("this");
            //instance.LIST2.Add("that");
            //instance.LIST2.Add("what");
            //instance.LIST2.Add("no"); 


            //var instance2 = new Customer();
            ////return View("NewPage",instance2);
            //return View("NewPage",instance2);
            return View();
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

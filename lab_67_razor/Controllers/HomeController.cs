using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_67_razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("About"); // selects the page that will be seen first
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewData["Message2"] = "Hello second message";
            return View();
        }
        public ActionResult RazorHelloWorld()
        {
            ViewData["Message"] = "Second razor message";
            ViewData["Message2"] = "Message 3?";
            var PassThisString = "Send some data from controller to view";
            return View("RazorHelloWorld");
        }
    }
}
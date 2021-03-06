using HelloWorldMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage()
            {
                Message = "Hello World!"
            };

            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message changed.";
            return View(obj);
        }

    }
}

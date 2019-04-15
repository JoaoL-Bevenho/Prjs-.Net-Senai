using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMedicos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Message = "Welcome";
            ViewBag.Message2 = "Continuing";
            ViewBag.Message3 = "Still Going...";
            ViewBag.Message4 = "Not even Halfway";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            ViewBag.Message = "Go Back";
            return View();
        }
    }
}
//Install-Package EntityFramework
//Enable-Migrations
//Add-Migration Initial
//Update-Database
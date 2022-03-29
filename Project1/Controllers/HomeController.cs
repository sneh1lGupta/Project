using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Registration Page";

            return View();
        }

        public ActionResult LogIn() {
            ViewBag.Message = "Login Page";

            return View();
        }

        public ActionResult ThankYou() {
            ViewBag.Message = "Thank You for Registering!";

            return View();
        }
 
    }
}
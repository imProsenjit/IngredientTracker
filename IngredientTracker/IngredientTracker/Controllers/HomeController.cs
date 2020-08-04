using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChefView()
        {
            return View();
        }

        public ActionResult ChefRecepie()
        {
            return View();
        }

        public ActionResult Recepie1()
        {
            return View();
        }

        public ActionResult Recepie2()
        {
            return View();
        }

        public ActionResult Recepie3()
        {
            return View();
        }

        public ActionResult Recepie4()
        {
            return View();
        }

        public ActionResult Recepie5()
        {
            return View();
        }

        public ActionResult Recepie6()
        {
            return View();
        }

        public ActionResult Recepie7()
        {
            return View();
        }

        public ActionResult Recepie8()
        {
            return View();
        }

        public ActionResult Recepie9()
        {
            return View();
        }

    }      
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IngredientTracker.Models;
using IngredientTracker.DataContext;

namespace IngredientTracker.Controllers
{
    public class ManagersController : Controller
    {
        DBIngredientTracker db = new DBIngredientTracker();
        public ActionResult UserType()
        {
            return View();
        }

        public ActionResult ManagerRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ManagerRegistration(ManagerRegistration mreg)
        {
            if (ModelState.IsValid)
            {
                db.ManagerRegistrations.Add(mreg);
                db.SaveChanges();
                return RedirectToAction("ManagerLogin");
            }
            return RedirectToAction("ManagerLogin");
        }

        public ActionResult ManagerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ManagerLogin(ManagerRegistration mlogin)
        {
            var managerlogin = db.ManagerRegistrations.Where(x => x.UserName == mlogin.UserName && x.Password == mlogin.Password).FirstOrDefault();
            if(managerlogin!=null)
            {
                Session["manager"] = mlogin.UserName;
                return RedirectToAction("Dashboard");
            }
            
            return View();
        }

        //Start Chef Interface

        public ActionResult ChefRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChefRegistration(Chef creg)
        {
            if (ModelState.IsValid)
            {
                db.Chefs.Add(creg);
                db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return RedirectToAction("Dashboard");
        }

        public ActionResult ChefLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChefLogin(Chef clogin)
        {
            var cheflogin = db.Chefs.Where(x => x.ChefUserName == clogin.ChefUserName && x.ChefPassword == clogin.ChefPassword).FirstOrDefault();
            if (cheflogin != null)
            {
                Session["chef"] = clogin.ChefUserName;
                return RedirectToAction("Dashboard");
            }

            return View();
        }

        //End Chef Interface


        //Start Dashboard **************************************************************************

        public ActionResult Dashboard()
        {
            return View();
        }

        //End Dashboard


        //Start Ingredient **************************************************************************

        public ActionResult IngredientHome()
        {
            return View();
        }

        public ActionResult AddIngredient()
        {
            return View();
        }

        public ActionResult UpdateIngredient()
        {
            return View();
        }

        public ActionResult ListIngredient()
        {
            return View();
        }

        //End Ingredient

        //Start Recipe *******************************************************************************

        public ActionResult RecipeHome()
        {
            return View();
        }

        //End Recipe


    }
}
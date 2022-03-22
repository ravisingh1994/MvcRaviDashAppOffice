using MvcRaviDashApp.DB_Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRaviDashApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmpData()
        {
            return View();
        }

        public ActionResult EmployeeDetails()
        {
            ChetuIndiaEntities ent = new ChetuIndiaEntities();

            var empdata = ent.EmpChetus.ToList();


            return View(empdata);
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
    }
}
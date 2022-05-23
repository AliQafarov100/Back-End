using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_e_basladim_insAllah_yaxsi_oyrenerem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Product = "Tutku";
            ViewData["Count"] = 20;
            TempData["Price"] = "0.9";
            return RedirectToAction("About");
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ(string name,string surname)
        {
            string fullname = $"{name} {surname}";
            return Content(fullname);
        }
    }
}

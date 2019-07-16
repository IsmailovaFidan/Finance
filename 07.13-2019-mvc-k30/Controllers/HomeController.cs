using _07._13_2019_mvc_k30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07._13_2019_mvc_k30.Controllers
{
    public class HomeController : Controller
    {
        financeDBEntities3 db = new financeDBEntities3();
        public ActionResult Index()
        {
            ViewBag.topSection = db.TopSection1.First();
            ViewBag.section2Div1 = db.Section2Div1.First();
            ViewBag.section2 = db.Section2Div2.ToList();
            ViewBag.section3Div1 = db.Section3Div1.First();
            ViewBag.section3Div2 = db.Section3Div2.ToList();
            ViewBag.section5Divs = db.Section5Divs.First();
            ViewBag.ourproject = db.OurProject.First();
            ViewBag.ourprojectPhoto = db.OurProjectPhoto.ToList();
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
    }
}
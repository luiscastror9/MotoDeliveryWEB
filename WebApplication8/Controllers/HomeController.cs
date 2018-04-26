using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Demo1()
        {
            return View();
        }

        public ActionResult Demo2(FormCollection data)
        {
            MotoDeliveryEntities2 mde = new MotoDeliveryEntities2();
            Traslado u = new Traslado();
            u.calle_in = data["travelfrom"];

            Session.Add("viajeida", data["travelfrom"]);
            return View();
        }

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
    }
}
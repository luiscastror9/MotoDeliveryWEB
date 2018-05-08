using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using WebApplication8;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Informacion de contacto";

            return View();
        }
    }
}
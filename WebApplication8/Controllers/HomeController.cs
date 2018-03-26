﻿using System;
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
        /*
        public ActionResult Demo2()
        {
            var source, destination;
            var directionsDisplay;
            var directionsService = new google.maps.DirectionsService();
            return View();
        }*/

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
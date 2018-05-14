using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using WebApplication8;
using System.Configuration;
using WebApplication8.Datos;
using System.Threading.Tasks;

namespace WebApplication8.Controllers
{
    
    public class HomeController : Controller
    
    {
        private Task<UserData> db;

        public object userData { get; private set; }

        public ActionResult Index()
        {
            string valor = "valor de cookie";
            HttpCookie cookie1 = new HttpCookie("foo_one", valor);
            ControllerContext.HttpContext.Response.SetCookie(cookie1);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Informacion de contacto";

            return View();
        }
        
        public ActionResult Details()
        {
           
                return View("Details", "UserDatas");
            
                    
        }
       

    }
}
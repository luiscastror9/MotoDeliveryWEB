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
        public ActionResult Demo1()
        {
            return View();
        }

        public ActionResult Demo2(FormCollection data)
       {
            using (MotoDeliveryEntities2 db = new MotoDeliveryEntities2())
            {
                var u = new Traslado
                {
                    usuario_id = 1,
                    id_moto = 6,
                    tarifa = data["pasarTarifa"],
                    calle_in = data["travelfrom"],
                    calle_fn = data["travelto"],
                    estado_viaje = 1,
                };
                db.Traslado.Add(u);
            }
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
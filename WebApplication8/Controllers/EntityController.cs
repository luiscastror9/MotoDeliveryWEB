using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace WebApplication8.Controllers
{

    public class EntityController : Controller
    {
        // GET: Entity
        public ActionResult Index()
        {
            return View();
        }
    }

    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void AddTraslados(Traslado nuevoTraslado)
        {
            using (MotoDeliveryEntities2 DBF = new MotoDeliveryEntities2())
            {
                Traslado Traslado = new Traslado
                {
                    usuario_id = nuevoTraslado.usuario_id,
                    id_moto = nuevoTraslado.id_moto,
                    tarifa = nuevoTraslado.tarifa,
                    calle_in = nuevoTraslado.calle_in,
                    calle_fn = nuevoTraslado.calle_fn,
                    estado_viaje = 1
                };

                DBF.Traslado.Add(Traslado);
                DBF.SaveChanges();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Traslado nuevoTraslado = new Traslado { };
            AddTraslados(nuevoTraslado);
        }
    }
}
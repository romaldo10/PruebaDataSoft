using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaDataSoft.Controllers
{
    //Controlador de entidad de servicios
    public class ServicioController : Controller
    {
        // GET de entidad de Servicio 
        public ActionResult Index()
        {
            var srv = ServicioCN.ListarServicios();
            return View(srv);
        }

        // POST de entidad de Servicio 
        public ActionResult Crear () 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear (Servicios srv)
        {
            try
            {
                ServicioCN.Agregar(srv);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View(srv);
            }
          
        }
    }
}
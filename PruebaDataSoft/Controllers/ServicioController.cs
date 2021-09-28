using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PruebaDataSoft.Controllers
{
    //Controlador de entidad de servicios
    public class ServicioController : Controller
    {
        // GET list de entidad de Servicio 
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
                if (srv.Descripción ==null)
                {
                    ModelState.AddModelError("", "Debe escribir la descripción del servicio..");
                    return View(srv);
                }
                if (srv.Monto < 1)
                {
                    ModelState.AddModelError("", "Debe escribir un monto superior a 0");
                    return View(srv);
                }
                ServicioCN.PostServicio(srv);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View(srv);
            }
          
        }

        // GET ID de entidad de Servicio 
        public ActionResult Detalle(int id)
        {
            var srv = ServicioCN.GetServicio(id);
            return View(srv);
        }

        //PUT de entidad de Servicio
        public ActionResult Editar(int id)
        {
            var srv = ServicioCN.GetServicio(id);
            return View(srv);
        }

        [HttpPost]
        public ActionResult Editar(Servicios srv)
        {
            try
            {
                if (srv.Descripción == null)
                {
                    ModelState.AddModelError("", "Debe escribir la descripción del servicio..");
                    return View(srv);
                }
                if (srv.Monto <1)
                {
                    ModelState.AddModelError("", "Debe escribir un monto superior a 0");
                    return View(srv);
                }
                ServicioCN.PutServicio(srv);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View(srv);
            }

        }
        //DELETE de entidad de Servicio
        public ActionResult Borrar(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var srv = ServicioCN.GetServicio(id.Value);
            return View(srv);
        }
        [HttpPost]
        public ActionResult Borrar(int id)
        {
            try
            {
               
                ServicioCN.DeleteServicio(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View();
            }
        }

        //Lista en select de asinar servicio
        public JsonResult ListarServicios()
        {
            try
            {
                var lista = ServicioCN.ListarServicios();
                return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        //Lista de operaciones
        public ActionResult ListarOperaciones()
        {
            return View(ServicioCN.ListarOperaciones());
        }

    }
}
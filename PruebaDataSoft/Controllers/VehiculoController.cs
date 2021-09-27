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
    public class VehiculoController : Controller
    {
        //Controlador de entidad de vehiculo
      
            // GET list de entidad de Vehiculo 
            public ActionResult Index()
            {
                var vhc = VehiculoCN.ListarVehiculo();
                return View(vhc);
            }

            // POST de entidad de Vehiculo 
            public ActionResult Crear()
            {
                return View();
            }
        [HttpPost]
        public ActionResult Crear(Vehiculo vhc)
        {
            try
            {
                if (vhc.Placa == null)
                {
                    ModelState.AddModelError("", "Debe escribir el número de placa..");
                    return View(vhc);
                }
                if (vhc.Dueño == null)
                {
                    ModelState.AddModelError("", "Debe escribir el nombre del dueño del vehiculo..");
                    return View(vhc);
                }
                if (vhc.Marca == null)
                {
                    ModelState.AddModelError("", "Debe escribir la marca del vehiculo..");
                    return View(vhc);
                }

                VehiculoCN.PostVehiculo(vhc);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View(vhc);
            }

        }

        // GET ID de entidad de Vehiculo 
        public ActionResult Detalle(int id)
        {
            var vhc = VehiculoCN.GetVehiculo(id);
            return View(vhc);
        }

        //PUT de entidad de Vehiculo
        public ActionResult Editar(int id)
        {
            var vhc = VehiculoCN.GetVehiculo(id);
            return View(vhc);
        }

        [HttpPost]
        public ActionResult Editar(Vehiculo vhc)
        {
            try
            {
                if (vhc.Placa == null)
                {
                    ModelState.AddModelError("", "Debe escribir el número de placa..");
                    return View(vhc);
                }
                if (vhc.Dueño == null)
                {
                    ModelState.AddModelError("", "Debe escribir el nombre del dueño del vehiculo..");
                    return View(vhc);
                }
                if (vhc.Marca == null)
                {
                    ModelState.AddModelError("", "Debe escribir la marca del vehiculo..");
                    return View(vhc);
                }
                VehiculoCN.PutVehiculo(vhc);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View(vhc);
            }

        }

        //DELETE de entidad de Vehiculo
        public ActionResult Borrar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var vhc = VehiculoCN.GetVehiculo(id.Value);
            return View(vhc);
        }
        [HttpPost]
        public ActionResult Borrar(int id)
        {
            try
            {

                VehiculoCN.DeleteVehiculo(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurriò el siguiente error: ", ex.Message);
                return View();
            }
        }

    }
}
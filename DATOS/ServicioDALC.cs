using System;
using ENTIDAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
   public  class ServicioDALC
    {
        //Modelo de datos entidad de Servicios 

        //Agregar dato
        public void PostServicio(Servicios srv)
        {
            using (var db = new PruebaDbContext())
            {
                db.Servicios.Add(srv);
                db.SaveChanges();
            }
        }
        //Listar datos
        public List<Servicios> ListarServicios()
        {
            using (var db = new PruebaDbContext())
            {
                return db.Servicios.ToList();
            }
        }

        //Obtener dato
        public Servicios GetServicio(int id)
        {
            using (var db = new PruebaDbContext())
            {
                return db.Servicios.Where(s => s.ID_Servicio == id).FirstOrDefault();
            }
        }

        //Editar dato
        public void PutServicio(Servicios srv)
        {
            using (var db= new PruebaDbContext())
            {
                var s = db.Servicios.Find(srv.ID_Servicio);
                s.Descripción = srv.Descripción;
                s.Monto = srv.Monto;
                db.SaveChanges();
            }
        }

        //Borrar dato
        public void DeleteServicio(int id)
        {
            using (var db = new PruebaDbContext())
            {
                var srv = db.Servicios.Find(id);
                db.Servicios.Remove(srv);
                db.SaveChanges();

            }

        }

    }
}

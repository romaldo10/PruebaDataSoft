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
        public void Agregar(Servicios srv)
        {
            using (var db = new PruebaDbContext())
            {
                db.Servicios.Add(srv);
                db.SaveChanges();
            }
        } 

        public List<Servicios> ListarServicios()
        {
            using (var db = new PruebaDbContext())
            {
                return db.Servicios.ToList();
            }
        }

    }
}

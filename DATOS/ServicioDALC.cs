using System;
using ENTIDAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                db.Configuration.LazyLoadingEnabled = false;
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

        public List<OperacionesCE> ListarAsignaciones(int[] servicioId)
        {
            throw new NotImplementedException();
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

        //Listar Operaciones
        public List<OperacionesCE> ListarOperaciones()
        {
            string sql = @"   select ve.[ID_Vehiculo-Servicio] as ID,s.Descripción as Servicio, v.Marca as Vehiculo, v.Dueño, v.Placa, s.Monto 
                       from [Vehiculo-Servicio] ve
                       inner join Vehiculo v on ve.ID_Vehiculo = v.ID_Vehiculo
                       inner join Servicios s on ve.ID_Servicio = s.ID_Servicio
                       order by ve.[ID_Vehiculo-Servicio] desc;";
            using (var db = new PruebaDbContext())
            {
                return db.Database.SqlQuery<OperacionesCE>(sql).ToList();
            }
        }

      


    }
}

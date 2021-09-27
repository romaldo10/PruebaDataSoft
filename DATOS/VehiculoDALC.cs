using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    //Modelo de datos entidad de Vehiculo 

 
    public class VehiculoDALC
    {
        //Agregar dato
        public void PostVehiculo(Vehiculo srv)
        {
            using (var db = new PruebaDbContext())
            {
                db.Vehiculo.Add(srv);
                db.SaveChanges();
            }
        }

        //Listar datos
        public List<Vehiculo> ListarVehiculo()
        {
            using (var db = new PruebaDbContext())
            {
                return db.Vehiculo.ToList();
            }
        }

        //Obtener dato
        public Vehiculo GetVehiculo(int id)
        {
            using (var db = new PruebaDbContext())
            {
                return db.Vehiculo.Where(s => s.ID_Vehiculo == id).FirstOrDefault();
            }
        }

        //Editar dato
        public void PutVehiculo(Vehiculo vhc)
        {
            using (var db = new PruebaDbContext())
            {
                var v = db.Vehiculo.Find(vhc.ID_Vehiculo);
                v.Placa = vhc.Placa;
                v.Dueño = vhc.Dueño;
                v.Marca = vhc.Marca;
                db.SaveChanges();
            }
        }

        //Borrar dato
        public void DeleteVehiculo(int id)
        {
            using (var db = new PruebaDbContext())
            {
                var vhc = db.Vehiculo.Find(id);
                db.Vehiculo.Remove(vhc);
                db.SaveChanges();

            }

        }

    }
}

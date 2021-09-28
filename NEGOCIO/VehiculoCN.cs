using System;
using ENTIDAD;
using DATOS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
   public class VehiculoCN
    {
        // Medodos CRUD capa de negocio entidad de Vehiculo 
        private static VehiculoDALC obj = new VehiculoDALC();

        //Prepara insersion
        public static void PostVehiculo(Vehiculo vhc)
        {
            obj.PostVehiculo(vhc);
        }

        //Solicita listado
        public static List<Vehiculo> ListarVehiculo()
        {
            return obj.ListarVehiculo();
        }

        //Solicita dato
        public static Vehiculo GetVehiculo(int id)
        {
            return obj.GetVehiculo(id);
        }

        //Solicita edicion
        public static void PutVehiculo(Vehiculo vhc)
        {
            obj.PutVehiculo(vhc);
        }

        //Solicita borrar
        public static void DeleteVehiculo(int id)
        {
            obj.DeleteVehiculo(id);
        }

        //Solicita asignacion de servicio
        public static void AsignarServicio(int servicioId, int vehiculoId)
        {
            obj.AsignarServicio(servicioId, vehiculoId);
        }
    }
}

using System;
using ENTIDAD;
using DATOS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
   public class ServicioCN
    {
        // Medodos CRUD capa de negocio entidad de Servicios 
        private static ServicioDALC obj = new ServicioDALC();

        public static void Agregar(Servicios srv)
        {
            obj.Agregar(srv);
        }

        public static List<Servicios> ListarServicios()
        {
            return obj.ListarServicios();
        }
    }
}

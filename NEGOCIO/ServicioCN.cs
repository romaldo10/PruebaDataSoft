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

        //Prepara insersion
        public static void PostServicio(Servicios srv)
        {
            obj.PostServicio(srv);
        }

        //Solicita listado
        public static List<Servicios> ListarServicios()
        {
            return obj.ListarServicios();
        }

        //Solicita dato
        public static Servicios GetServicio(int id)
        {
            return obj.GetServicio(id);
        }

        //Solicita edicion
        public static void PutServicio(Servicios srv)
        {
            obj.PutServicio(srv);
        }

        //Solicita borrar
        public static void DeleteServicio(int id)
        {
            obj.DeleteServicio(id);
        }

        //Listar Operaciones
        public static List<OperacionesCE> ListarOperaciones()
        {
           return obj.ListarOperaciones();
        }

    }
}

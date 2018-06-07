using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AvisosBusiness
    {

        public void agregar(DateTime Fecha, int Id, string Asunto, string Detalle)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SP_Crear_Avisos";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Fecha", Fecha);
                conexion.agregarParametro("@Usuario", Id);
                conexion.agregarParametro("@Asunto", Asunto);
                conexion.agregarParametro("@Detalle", Detalle);


                conexion.setearSP(consulta);
                conexion.accionEjecutar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}

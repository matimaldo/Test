using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AbonoBusiness
    {

        public string ObtenerPercioDia()
        {
            string aux = "";
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT valor FROM Abonos WHERE Vigente = 1 and Cantidad_Ingresos = 1 ";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux = conexion.Lector.GetDecimal(0).ToString("N2");
                }
                return aux;

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

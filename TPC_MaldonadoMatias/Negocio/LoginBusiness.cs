using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginBusiness
    {
        public bool ingresar(string Usuario, string Clave )
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Usuario , Clave FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Clave ";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Usuario", Usuario);
                conexion.agregarParametro("@Clave", Clave);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {

                    return true;

                }
                return false;
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

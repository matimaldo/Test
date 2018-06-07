using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

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

        public Usuario ObtenerDatos(string usuario, string clave)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_ObtenerUsuario";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Usuario", usuario);
                conexion.agregarParametro("@Clave", clave);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                Usuario aux = new Usuario();
                while (conexion.Lector.Read())
                {
                    aux.IdUsuario = conexion.Lector.GetInt32(0);
                    aux.NMUsuario = conexion.Lector.GetString(1);
                    aux.Persona.IdPersona = conexion.Lector.GetInt32(2);
                    aux.Persona.Apellido = conexion.Lector.GetString(3);
                    aux.Persona.Nombre = conexion.Lector.GetString(4);
                    aux.Rol.IdRol = conexion.Lector.GetInt32(5);
                    aux.Rol.NMRol = conexion.Lector.GetString(6);
                    aux.Persona.Apno="";
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

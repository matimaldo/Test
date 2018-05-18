using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioBusiness
    {

        public Usuario obtener(int IdPersona)
        {

            AccesoDatos conexion = new AccesoDatos();
            Usuario aux = new Usuario();


            aux.IdUsuario = 0;
            aux.IdUsuario = 0;
            aux.NMUsuario = "";
            aux.Clave = "";

            string consulta = "SELECT Id_Usuario, Id_Persona,Usuario,Clave FROM Usuarios WHERE Id_Persona = @IdPersona";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdPersona", IdPersona);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    

                    aux.IdUsuario = conexion.Lector.GetInt32(0);
                    aux.IdUsuario = conexion.Lector.GetInt32(1);
                    aux.NMUsuario = conexion.Lector.GetString(2);
                    aux.Clave = conexion.Lector.GetString(3);

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

        public void agregar(Usuario usuario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO Usuarios VALUES (@Id_Persona, @Usuario, @Clave)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_Persona", usuario.Persona.IdPersona);
                conexion.agregarParametro("@Usuario", usuario.NMUsuario);
                conexion.agregarParametro("@Clave", usuario.Clave);


                conexion.setearConsulta(consulta);
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

        public void modificar(Usuario usuario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Usuarios SET Usuario = @Usuario , Clave = @Clave WHERE Id_Persona = @IdPersona";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Usuario", usuario.NMUsuario);
                conexion.agregarParametro("@Clave", usuario.Clave);
                conexion.agregarParametro("@IdPersona", usuario.Persona.IdPersona);


                conexion.setearConsulta(consulta);
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

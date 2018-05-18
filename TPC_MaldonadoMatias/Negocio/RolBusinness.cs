using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class RolBusinness
    {
        public void nuevo(AnioLectivo anio)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO AnioLectivo VALUES (@anio)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@anio", anio.Anio);

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

        public void eliminar(AnioLectivo anio)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "DELETE FROM AnioLectivo WHERE Id_Anio = @id";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@id", anio.IdAnio);

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

        public IList<Rol> listar()
        {

            IList<Rol> lista = new List<Rol>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Rol, NM_Rol FROM Roles WHERE NM_ROL <> 'Admin' ORDER BY 2";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Rol aux = new Rol();

                    aux.IdRol = conexion.Lector.GetInt32(0);
                    aux.NMRol = conexion.Lector.GetString(1);

                    lista.Add(aux);
                }
                return lista;
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

        public void agregar(int IdRol, int IdPersona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO RolxPersona VALUES (@IdPersona, @IdRol)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdPersona", IdPersona);
                conexion.agregarParametro("@IdRol",IdRol);

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

        public int obtenerRol(int IdPersona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT R.Id_Rol, R.NM_Rol FROM Roles R INNER JOIN RolxPersona RP ON R.Id_Rol = RP.Id_Rol WHERE RP.Id_Persona = @Id_Persona ";

            Rol aux = new Rol();
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_Persona", IdPersona);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdRol = conexion.Lector.GetInt32(0);
                    aux.NMRol = conexion.Lector.GetString(1);


                }
                return aux.IdRol;
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

        public void modificar(int IdRol, int IdPersona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE RolxPersona SET Id_Rol = @IdRol WHERE Id_Persona =@IdPersona";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdPersona", IdPersona);
                conexion.agregarParametro("@IdRol", IdRol);

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

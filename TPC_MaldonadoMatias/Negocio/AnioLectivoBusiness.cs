using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class AnioLectivoBusiness
    {
        public void agregar(AnioLectivo anio)
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

        public IList<AnioLectivo> listar()
        {

            IList<AnioLectivo> lista = new List<AnioLectivo>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Anio, Anio FROM AnioLectivo ORDER BY 2";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    AnioLectivo aux = new AnioLectivo();

                    aux.IdAnio = conexion.Lector.GetInt32(0);
                    aux.Anio = conexion.Lector.GetInt32(1);

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
    }
}

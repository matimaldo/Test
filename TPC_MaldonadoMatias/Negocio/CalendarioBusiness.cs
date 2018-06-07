using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;
using System.Windows.Forms;

namespace Negocio
{
    public class CalendarioBusiness
    {
        public IList<DateTime> listar()
        {
            IList<DateTime> lista = new List<DateTime>();
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT Nombre, Apellido, FechaNac FROM Personas";

            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    DateTime aux = new DateTime();

                    aux = conexion.Lector.GetDateTime(2);

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

        public IList<DateTime> listarAvisos()
        {
            IList<DateTime> lista = new List<DateTime>();
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT DISTINCT Fecha FROM Avisos";

            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    DateTime aux = new DateTime();

                    aux = conexion.Lector.GetDateTime(0);

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

        public IList<String> AvisosCumple(DateTime fechaSelecionada)
        {
            IList<String> lista = new List<String>();
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT Nombre, Apellido, FechaNac FROM Personas";

            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    String aux;
                    DateTime fecha = new DateTime();

                    fecha = conexion.Lector.GetDateTime(2);

                    fecha = (new DateTime(fechaSelecionada.Year, fecha.Month, fecha.Day));

                    if (fecha == fechaSelecionada)
                    {
                        aux = "Cumpleaños de " + conexion.Lector.GetString(0) +" "+ conexion.Lector.GetString(1);
                        lista.Add(aux);

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }


            AccesoDatos conexion2 = new AccesoDatos();
            string consulta2 = "SELECT Asunto, Fecha FROM Avisos";

            try
            {
                conexion2.setearConsulta(consulta2);
                conexion2.leerConsulta();

                while (conexion2.Lector.Read())
                {
                    String aux;
                    DateTime fecha = new DateTime();

                    fecha = conexion2.Lector.GetDateTime(1);

                    fecha = (new DateTime(fecha.Year, fecha.Month, fecha.Day));

                    if (fecha == fechaSelecionada)
                    {
                        aux = conexion2.Lector.GetString(0);
                        lista.Add(aux);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion2.cerrarConexion();
            }
        }
    }
}

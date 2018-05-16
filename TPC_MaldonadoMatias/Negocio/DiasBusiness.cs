using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DiasBusiness
    {
        public IList<Horario> listarDisponible(int dia)
        {
            IList<Horario> lista = new List<Horario>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT H.Id_Horario, H.Horario_Desde, H.Horario_Hasta FROM Horarios H LEFT JOIN (SELECT * FROM DiasXHorario WHERE Id_Dia = @Id_dia) AS DH ON H.Id_Horario = DH.Id_Horario WHERE DH.Id_Dia IS NULL";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_dia", dia);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Horario aux = new Horario();

                    aux.IdHorario = conexion.Lector.GetInt32(0);
                    aux.Desde = conexion.Lector.GetDateTime(1);
                    aux.Hasta = conexion.Lector.GetDateTime(2);

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

        public IList<Horario> listarCargado(int dia)
        {
            IList<Horario> lista = new List<Horario>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT H.Id_Horario, H.Horario_Desde, H.Horario_Hasta FROM Horarios H INNER JOIN (SELECT * FROM DiasXHorario WHERE Id_Dia = @Id_dia) AS DH ON H.Id_Horario = DH.Id_Horario";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_dia", dia);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Horario aux = new Horario();

                    aux.IdHorario = conexion.Lector.GetInt32(0);
                    aux.Desde = conexion.Lector.GetDateTime(1);
                    aux.Hasta = conexion.Lector.GetDateTime(2);

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

        public void agregar(int dia, Horario horario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO DiasXHorario VALUES (@IdDia, @IdHorario)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdDia", dia);
                conexion.agregarParametro("@IdHorario", horario.IdHorario);

                conexion.setearConsulta(consulta);
                conexion.accionEjecutar();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No hay Horarios Disponibles para Agregar");
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

        public void eliminar(int dia, Horario horario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "DELETE FROM DiasXHorario WHERE Id_Dia = @IdDia AND Id_Horario = @IdHorario";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdDia", dia);
                conexion.agregarParametro("@IdHorario", horario.IdHorario);

                conexion.setearConsulta(consulta);
                conexion.accionEjecutar();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No hay Horarios Disponibles para Sacar");
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

        public void eliminarTodo(int dia)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "DELETE FROM DiasXHorario WHERE Id_Dia = @IdDia";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdDia", dia);

                conexion.setearConsulta(consulta);
                conexion.accionEjecutar();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No hay Horarios Disponibles para Sacar");
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

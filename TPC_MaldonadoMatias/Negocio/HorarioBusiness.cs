using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Negocio
{
    public class HorarioBusiness
    {
        public IList<Horario> listar()
        {
            IList<Horario> lista = new List<Horario>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Horario, Horario_Desde, Horario_Hasta  FROM Horarios ORDER BY 2,3";
            try
            {
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

        public void agregar(Horario horario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO Horarios VALUES (@Horario_Desde, @Horario_Hasta)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Horario_Desde", horario.Desde);
                conexion.agregarParametro("@Horario_Hasta", horario.Hasta); 

                conexion.setearConsulta(consulta);
                conexion.accionEjecutar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void eliminar(Horario horario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "DELETE FROM Horarios WHERE Id_Horario = @id";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@id", horario.IdHorario);

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

        //public int apertura()
        //{
        //    AccesoDatos conexion = new AccesoDatos();
        //    int apertura = new int();

        //    string consulta = "SELECT ISNULL(MIN(DATEPART(HOUR,Horario_Desde)),0) FROM Horarios";
        //    try
        //    {
        //        conexion.setearConsulta(consulta);
        //        conexion.leerConsulta();

        //        while (conexion.Lector.Read())
        //        {
        //            apertura = conexion.Lector.GetInt32(0);
        //        }
        //        return apertura;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conexion.cerrarConexion();
        //    }
        //}

        //public int cierre()
        //{
        //    AccesoDatos conexion = new AccesoDatos();
        //    int apertura = new int();

        //    string consulta = "SELECT ISNULL(MAX(DATEPART(HOUR,Horario_Hasta)),0) FROM Horarios";
        //    try
        //    {
        //        conexion.setearConsulta(consulta);
        //        conexion.leerConsulta();

        //        while (conexion.Lector.Read())
        //        {
        //            apertura = conexion.Lector.GetInt32(0);
        //        }
        //        return apertura;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conexion.cerrarConexion();
        //    }
        //}
    }
}

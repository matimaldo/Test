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


        public IList<String> Avisos(DateTime fechaSelecionada)
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
        //public void CargarLista()
        //{

        //    SqlConnection conexion = new SqlConnection();
        //    SqlCommand comando = new SqlCommand();
        //    SqlDataReader lector;

        //    listBox1.Items.Clear();

        //    try
        //    {
        //        conexion.ConnectionString = @"data source=.; initial catalog=EJEMPLO; integrated security=sspi";
        //        comando.CommandType = System.Data.CommandType.Text;
        //        comando.Connection = conexion;
        //        comando.CommandText = "SELECT Id_Usuario, Nombre, Clave, Fecha Nombre FROM Usuarios";

        //        conexion.Open();

        //        lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            DateTime Fecha = lector.GetDateTime(3);
        //            Fecha = (new DateTime(monthCalendar1.SelectionStart.Year, Fecha.Month, Fecha.Day));

        //            if (Fecha == monthCalendar1.SelectionStart)

        //                listBox1.Items.Add("Cumpleaños de " + lector.GetString(1));

        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}
    }
}

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
    public class ExamenBusiness
    {
        public void Agregar(Examen examen)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Examen_Agregar";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", examen.NombreExamen);
                conexion.agregarParametro("@Fecha", examen.Fecha);
                conexion.agregarParametro("@Tipo", examen.TipoExamen.IdTipoExamen);
                conexion.agregarParametro("@Cursada", examen.Cursada.IdCursada);

                conexion.setearSP(consulta);
                conexion.accionEjecutar();

                MessageBox.Show("Guardado con Exito!");

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    
                   MessageBox.Show("Ya Existe este nombre para esta Curso!");
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


        public IList<Examen> ListarExamenRecuperar(Cursada cursada)
        {

            IList<Examen> lista = new List<Examen>();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "SP_Examen_ListarRecuperar";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("Cursada", cursada.IdCursada);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Examen aux = new Examen();

                    aux.IdExamen = conexion.Lector.GetInt32(0);
                    aux.NombreExamen = conexion.Lector.GetString(1);

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

        public IList<Examen> ListarExamen(Cursada cursada)
        {

            IList<Examen> lista = new List<Examen>();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "SP_Examen_Listar";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("Cursada", cursada.IdCursada);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Examen aux = new Examen();

                    aux.IdExamen = conexion.Lector.GetInt32(0);
                    aux.NombreExamen = conexion.Lector.GetString(1);

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

        public void AgregarNota(int IdExamen, int IdPersona, int? Nota)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Examen_CargaNota";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdExamen", IdExamen);
                conexion.agregarParametro("@IdPersona", IdPersona);

                if (Nota == 0)
                    conexion.agregarParametro("@Nota", DBNull.Value);
                else
                    conexion.agregarParametro("@Nota", Nota);

                conexion.setearSP(consulta);
                conexion.accionEjecutar();

                //MessageBox.Show("Guardado con Exito!");

            }
            //catch (SqlException ex)
            //{
            //    if (ex.Number == 2627)

            //        MessageBox.Show("Ya se Cargaron las Notas!");
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }




    }
}

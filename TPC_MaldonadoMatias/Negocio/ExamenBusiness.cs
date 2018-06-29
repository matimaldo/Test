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

        public bool SeCargoNota(Examen examen)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "select * from ExamenXAlumno WHERE Id_Examen = @Examen";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Examen", examen.IdExamen);
    
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

        public void AgregarNota(int IdExamen, int IdPersona, decimal? Nota)
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

        public decimal TraerNota(int IdExamen, int IdPersona)
        {
            AccesoDatos conexion = new AccesoDatos();
            decimal nro = new decimal();
            nro = 0;

            string consulta = "SELECT Nota FROM ExamenXAlumno WHERE Id_Examen = @IdExamen  AND Id_Persona = @IdPersona";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdExamen", IdExamen);
                conexion.agregarParametro("@IdPersona", IdPersona);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {                   
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Nota")))
                    {
                        nro = conexion.Lector.GetDecimal(0);
                    }
                    else
                    {
                        nro = 0;
                    }
                }
                return nro;
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

        public void ActualizarNota(int IdExamen, int IdPersona, decimal? Nota)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Examen_ActualizarNota";
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

    }
}

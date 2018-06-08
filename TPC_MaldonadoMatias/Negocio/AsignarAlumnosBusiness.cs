using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AsignarAlumnosBusiness
    {
        public IList<AnioLectivo> listarAnio()
        {

            IList<AnioLectivo> lista = new List<AnioLectivo>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_AA_ListarAnios";
            try
            {
                conexion.setearSP(consulta);
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

        public IList<Curso> listarCurso(AnioLectivo anio)
        {

            IList<Curso> lista = new List<Curso>();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "SP_AA_ListarCurso";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("Anio", anio.IdAnio);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Curso aux = new Curso();

                    aux.IdCurso = conexion.Lector.GetInt32(0);
                    aux.NombreCurso = conexion.Lector.GetString(1);

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

        public IList<Comision> listarComision(AnioLectivo anio, Curso curso)
        {

            IList<Comision> lista = new List<Comision>();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "SP_AA_ListarComision";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("Anio", anio.IdAnio);
                conexion.agregarParametro("Curso", curso.IdCurso);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Comision aux = new Comision();

                    aux.IdComision = conexion.Lector.GetInt32(0);
                    aux.NombreComision = conexion.Lector.GetString(1);

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

        public IList<Alumno> listarAlumnosDisponibles()
        {

            IList<Alumno> lista = new List<Alumno>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_AA_ListarAlumnosDisponibles";
            try
            {
                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Alumno aux = new Alumno();

                    aux.IdPersona = conexion.Lector.GetInt32(0);
                    aux.Apellido = conexion.Lector.GetString(1);
                    aux.Nombre = conexion.Lector.GetString(2);
                    aux.Apno = "";

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

        public IList<Alumno> listarAlumnosEnCurso(int IdCursada)
        {

            IList<Alumno> lista = new List<Alumno>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_AA_ListarAlumnosEnCurso";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", IdCursada);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Alumno aux = new Alumno();

                    aux.IdPersona = conexion.Lector.GetInt32(1);
                    aux.Apellido = conexion.Lector.GetString(2);
                    aux.Nombre = conexion.Lector.GetString(3);
                    aux.Apno = "";

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

        public Cursada ObtenerIDCursada(AnioLectivo anio, Curso curso, Comision comision)
        {

            Cursada aux = new Cursada();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_AA_SeleccionarCursada";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Anio",anio.IdAnio);
                conexion.agregarParametro("@Curso",curso.IdCurso);
                conexion.agregarParametro("@Comision",comision.IdComision);
                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    

                    aux.IdCursada = conexion.Lector.GetInt32(0);
                    aux.CantidadMaxima = conexion.Lector.GetInt32(1);


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


        public void Agregar(int IdCursada ,Alumno alumno)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_AA_Agregar";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", IdCursada);
                conexion.agregarParametro("@Alumno", alumno.IdPersona);
                conexion.setearSP(consulta);
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

        public void Eliminar(int IdCursada, Alumno alumno)
        {

            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_AA_Eliminar";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", IdCursada);
                conexion.agregarParametro("@Alumno", alumno.IdPersona);
                conexion.setearSP(consulta);
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

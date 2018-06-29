using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CursoBusiness
    {
        public IList<Curso> listar(int tipo, string buscar)
        {

            IList<Curso> lista = new List<Curso>();
            AccesoDatos conexion = new AccesoDatos();

            String where = "";
            switch (tipo)
            {
                case 0:
                    where = "NM_Curso like '%" + buscar + "%'";
                    break;
                case 1:
                    where = "Id_Curso = '" + buscar + "'";
                    break;
            }

            string consulta = "SELECT Id_Curso, NM_Curso FROM Cursos WHERE " + where + " ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
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

        public IList<Curso> listar()
        {

            IList<Curso> lista = new List<Curso>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Curso, NM_Curso FROM Cursos WHERE Eliminado = 0 ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
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

        public bool ValidarIngreso(string Nombre)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT * FROM Cursos WHERE NM_Curso = '" + Nombre+"'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    return false;
                }
                return true;
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

        public void agregar(Curso curso)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO CURSOS VALUES (@Nombre,0)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", curso.NombreCurso);
                
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

        public void modificar(Curso curso)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Cursos SET NM_Curso = @Nombre WHERE Id_Curso = @IdCurso";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", curso.NombreCurso);
                conexion.agregarParametro("@IdCurso", curso.IdCurso);

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

        public int obtenerIDMax()
        {
            AccesoDatos conexion = new AccesoDatos();
            int nro = new int();

            try
            {
                conexion.setearConsulta("SELECT MAX(Id_Curso) FROM Cursos WHERE Eliminado = 0");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    nro = conexion.Lector.GetInt32(0);
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

        public int obtenerIDMin()
        {
            AccesoDatos conexion = new AccesoDatos();
            int nro = new int();

            try
            {
                conexion.setearConsulta("SELECT MIN(Id_Curso) FROM Cursos WHERE Eliminado = 0");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    nro = conexion.Lector.GetInt32(0);
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

        public Curso IrA(int tipo, int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            Curso aux = new Curso();
            string consulta = "";

            try
            {
                switch (tipo)
                {
                    case 0:
                        consulta = "SELECT TOP(1) Id_Curso, NM_Curso  FROM Cursos WHERE Eliminado = 0 ORDER BY 1 ASC";
                        break;
                    case 1:
                        consulta = "SELECT TOP(1) Id_Curso, NM_Curso  FROM Cursos WHERE Eliminado = 0 AND Id_Curso <" + id.ToString() + "ORDER BY 1 DESC";
                        break;
                    case 2:
                        consulta = "SELECT TOP(1) Id_Curso, NM_Curso  FROM Cursos WHERE Eliminado = 0 AND Id_Curso >" + id.ToString() + "ORDER BY 1 ASC";
                        break;
                    case 3:
                        consulta = "SELECT TOP(1) Id_Curso, NM_Curso  FROM Cursos WHERE Eliminado = 0 ORDER BY 1 DESC";
                        break;
                }

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdCurso = conexion.Lector.GetInt32(0);
                    aux.NombreCurso = conexion.Lector.GetString(1);
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

        public int ctrl_eliminar(Curso curso)
        {
            AccesoDatos conexion = new AccesoDatos();
            int nro = new int();

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdCurso", curso.IdCurso);
                conexion.setearConsulta("SELECT COUNT(*) FROM Cursos C INNER JOIN Cursadas CA ON C.Id_Curso = CA.Id_Curso WHERE C.Id_Curso = @IdCurso");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    nro = conexion.Lector.GetInt32(0);
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

        public void eliminar(Curso curso)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Cursos SET Eliminado = 1 WHERE Id_Curso = @IdCurso";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdCurso", curso.IdCurso);

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

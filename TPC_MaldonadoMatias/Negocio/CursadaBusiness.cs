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
    public class CursadaBusiness
    {
        public IList<Cursada> listar()
        {

            IList<Cursada> lista = new List<Cursada>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Listar_Cursadas";
            try
            {
                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Cursada aux = new Cursada();

                    aux.IdCursada = conexion.Lector.GetInt32(0);
                    aux.Curso.IdCurso = conexion.Lector.GetInt32(1);
                    aux.Curso.NombreCurso = conexion.Lector.GetString(2);
                    aux.Anio.IdAnio = conexion.Lector.GetInt32(3);
                    aux.Anio.Anio = conexion.Lector.GetInt32(4);
                    aux.Comision.IdComision = conexion.Lector.GetInt32(5);
                    aux.Comision.NombreComision = conexion.Lector.GetString(6);
                    aux.Profesor.IdPersona = conexion.Lector.GetInt32(7);
                    aux.Profesor.Nombre = conexion.Lector.GetString(8);
                    aux.Profesor.Apellido = conexion.Lector.GetString(9);
                    //aux.Aula.IdAula = conexion.Lector.GetInt32(10);
                    //aux.Aula.NombreAula = conexion.Lector.GetString(11);
                    aux.CantidadMaxima = conexion.Lector.GetInt32(10);
                    aux.Estado = conexion.Lector.GetBoolean(11);

                    aux.ACC = "";

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

        public Cursada cursadaIrA(int tipo, int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            Cursada aux = new Cursada();
            string consulta = "";

            try
            {
                switch (tipo)
                {
                    case 0:
                        consulta = "SELECT TOP(1) Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado FROM Cursadas INNER JOIN Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN Personas ON Cursadas.Id_Profesor = Personas.Id_Persona ORDER BY 1 ASC";
                        break;
                    case 1:
                        consulta = "SELECT TOP(1) Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado FROM Cursadas INNER JOIN Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN Personas ON Cursadas.Id_Profesor = Personas.Id_Persona WHERE Cursadas.Id_Cursada <"+id.ToString()+"   ORDER BY 1 DESC";
                        break;
                    case 2:
                        consulta = "SELECT TOP(1) Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado FROM Cursadas INNER JOIN Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN Personas ON Cursadas.Id_Profesor = Personas.Id_Persona WHERE Cursadas.Id_Cursada >"+id.ToString()+"   ORDER BY 1 ASC";
                        break;
                    case 3:
                        consulta = "SELECT TOP(1) Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado FROM Cursadas INNER JOIN Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN Personas ON Cursadas.Id_Profesor = Personas.Id_Persona ORDER BY 1 DESC";
                        break;
                    case 4:
                        consulta = "SELECT TOP(1) Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado FROM Cursadas INNER JOIN Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN Personas ON Cursadas.Id_Profesor = Personas.Id_Persona WHERE Cursadas.Id_Cursada =" + id.ToString() + "   ORDER BY 1 ASC";
                        break;

                }

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdCursada = conexion.Lector.GetInt32(0);
                    aux.Curso.IdCurso = conexion.Lector.GetInt32(1);
                    aux.Curso.NombreCurso = conexion.Lector.GetString(2);
                    aux.Anio.IdAnio = conexion.Lector.GetInt32(3);
                    aux.Anio.Anio = conexion.Lector.GetInt32(4);
                    aux.Comision.IdComision = conexion.Lector.GetInt32(5);
                    aux.Comision.NombreComision = conexion.Lector.GetString(6);
                    aux.Profesor.IdPersona = conexion.Lector.GetInt32(7);
                    aux.Profesor.Nombre = conexion.Lector.GetString(8);
                    aux.Profesor.Apellido = conexion.Lector.GetString(9);
                    //aux.Aula.IdAula = conexion.Lector.GetInt32(10);
                    //aux.Aula.NombreAula = conexion.Lector.GetString(11);
                    aux.CantidadMaxima = conexion.Lector.GetInt32(10);
                    //aux.Estado = conexion.Lector.GetBoolean(11);
                    //aux.Turno.IdTurno = conexion.Lector.GetInt32(12);
                    //aux.Turno.NombreTurno = conexion.Lector.GetString(13);

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

        public int obtenerIDMax()
        {
            AccesoDatos conexion = new AccesoDatos();
            int nro = new int();

            try
            {
                conexion.setearConsulta("SELECT ISNULL(MAX(C.Id_Cursada),0) FROM Cursadas C");
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
                conexion.setearConsulta("SELECT ISNULL(MIN(C.Id_Cursada),0) FROM Cursadas C");
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

        public void agregarDgv(DataGridView dgv, int Id)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Listar_HorarioCursadas";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdCursada", Id);


                dgv.DataSource = conexion.agragarDataGridView(consulta);

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

        public void agregarHorario (int IdCursada, int IdDia, int IdHorario, int IdAula)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO CursadaXDias VALUES (@IdCursada, @IdDia, @IdHorario, @IdAula)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdCursada", IdCursada);
                conexion.agregarParametro("@IdDia", IdDia);
                conexion.agregarParametro("@IdHorario", IdHorario);
                conexion.agregarParametro("@IdAula", IdAula);

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

        public void eliminarHorario(int IdCursada, int IdDia, int IdHorario, int IdAula)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SP_Eliminar_HorarioCursadas";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_Cursada", IdCursada);
                conexion.agregarParametro("@Id_Dia", IdDia);
                conexion.agregarParametro("@Id_Horario", IdHorario);
                conexion.agregarParametro("@Id_Aula", IdAula);

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

        public void agregar(Cursada cursada)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SP_Agregar_Cursada";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdCurso", cursada.Curso.IdCurso);
                conexion.agregarParametro("@IdComision", cursada.Comision.IdComision);
                conexion.agregarParametro("@IdAnio", cursada.Anio.IdAnio);
                conexion.agregarParametro("@IdProfesor", cursada.Profesor.IdPersona);
                conexion.agregarParametro("@Cantidad", cursada.CantidadMaxima);

                conexion.setearSP(consulta);

                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    cursada.IdCursada = int.Parse(conexion.Lector[0].ToString());
                }

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

        public void actualizarProfesor(Cursada cursada)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Cursadas SET Id_Profesor = @IdProfesor, Cant_Max = @Cant  WHERE Id_Cursada = @IdCursada";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdProfesor", cursada.Profesor.IdPersona);
                conexion.agregarParametro("@IdCursada", cursada.IdCursada);
                conexion.agregarParametro("@Cant", cursada.CantidadMaxima);

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

        public IList<Cursada> listarxProfesor(int Id_Profesor)
        {

            IList<Cursada> lista = new List<Cursada>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Listar_Cursadas_Profesor";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Profesor", Id_Profesor);
                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Cursada aux = new Cursada();

                    aux.IdCursada = conexion.Lector.GetInt32(0);
                    aux.Curso.IdCurso = conexion.Lector.GetInt32(1);
                    aux.Curso.NombreCurso = conexion.Lector.GetString(2);
                    aux.Anio.IdAnio = conexion.Lector.GetInt32(3);
                    aux.Anio.Anio = conexion.Lector.GetInt32(4);
                    aux.Comision.IdComision = conexion.Lector.GetInt32(5);
                    aux.Comision.NombreComision = conexion.Lector.GetString(6);
                    aux.Profesor.IdPersona = conexion.Lector.GetInt32(7);
                    aux.Profesor.Nombre = conexion.Lector.GetString(8);
                    aux.Profesor.Apellido = conexion.Lector.GetString(9);
                    //aux.Aula.IdAula = conexion.Lector.GetInt32(10);
                    //aux.Aula.NombreAula = conexion.Lector.GetString(11);
                    aux.CantidadMaxima = conexion.Lector.GetInt32(10);
                    aux.Estado = conexion.Lector.GetBoolean(11);
                    aux.ACC = "";

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


        public IList<Alumno> listarAlumnos(int Id_Cursada)
        {

            IList<Alumno> lista = new List<Alumno>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Listar_Cursadas_Alumnos";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", Id_Cursada);
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


       public void TomarLista(int Id_Cursada, int Id_Persona, DateTime Fecha , bool Presente)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_TomarLista";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", Id_Cursada);
                conexion.agregarParametro("@Persona", Id_Persona);
                conexion.agregarParametro("@Fecha", Fecha);
                conexion.agregarParametro("@Presente", Presente);

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

       public bool SeTomoLista(int Id_Cursada, DateTime Fecha)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_SeTomoLista";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", Id_Cursada);
                conexion.agregarParametro("@Fecha", Fecha);

                conexion.setearSP(consulta);
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


        public void ListarAsistencia(DataGridView dgv, int Cursada)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Asistencia";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", Cursada);

                dgv.DataSource = conexion.agragarDataGridView(consulta);
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

        public bool ValidarAsistencia(int Id_Cursada)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT top(1)* FROM Asistencia WHERE Id_Cursada =@Cursada";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cursada", Id_Cursada);

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
    }
}

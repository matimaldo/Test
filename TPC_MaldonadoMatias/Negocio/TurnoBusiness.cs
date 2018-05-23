using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Windows.Forms;

namespace Negocio
{
    public class TurnoBusiness
    {
        public IList<Turno> listar()
        {
            IList<Turno> lista = new List<Turno>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Turno, Nm_Turno FROM Turnos ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Turno aux = new Turno();

                    aux.IdTurno = conexion.Lector.GetInt32(0);
                    aux.NombreTurno = conexion.Lector.GetString(1);

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

        public bool Existe(int IdHorario)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Turno FROM TurnoxHorario WHERE Id_Horario = @IdHorario";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdHorario", IdHorario);

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

        public void agregarTurnox(int IdTurno, int IdHorario)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO TurnoxHorario VALUES (@IdTurno, @IdHorario)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@IdTurno", IdTurno);
                conexion.agregarParametro("@IdHorario", IdHorario);

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

        public void modificarTurnox(int IdTurno, int IdHorario)
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "UPDATE TurnoxHorario SET Id_Turno = @IdTurno WHERE Id_Horario = @IdHorario";

                try
                {
                    conexion.borrarParametros();
                    conexion.agregarParametro("@IdTurno", IdTurno);
                    conexion.agregarParametro("@IdHorario", IdHorario);

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

        public void agregarDgv(DataGridView dgv)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_CARGA_HORARIOS";
            try
            {

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

    }
}

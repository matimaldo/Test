using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class AulaBusiness
    {
        public IList<Aula> listar(int tipo, string buscar)
        {

            IList<Aula> lista = new List<Aula>();
            AccesoDatos conexion = new AccesoDatos();

            String where = "";
            switch (tipo)
            {
                case 0:
                    where = "NM_Aula like '%" + buscar + "%'";
                    break;
                case 1:
                    where = "Id_Aula = '" + buscar + "'";
                    break;
            }

            string consulta = "SELECT Id_Aula, NM_Aula, Cantidad FROM Aulas " + where + " ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Aula aux = new Aula();

                    aux.IdAula = conexion.Lector.GetInt32(0);
                    aux.NombreAula = conexion.Lector.GetString(1);
                    aux.Cantidad = conexion.Lector.GetInt32(2);

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

        public IList<Aula> listar()
        {

            IList<Aula> lista = new List<Aula>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Aula, NM_Aula, Cantidad FROM Aulas ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Aula aux = new Aula();

                    aux.IdAula = conexion.Lector.GetInt32(0);
                    aux.NombreAula = conexion.Lector.GetString(1);
                    aux.Cantidad = conexion.Lector.GetInt32(2);

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

        public void agregar(Aula aula)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO Aulas VALUES (@Nombre , @Cantidad)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", aula.NombreAula);
                conexion.agregarParametro("@Cantidad", aula.Cantidad);

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

        public void modificar(Aula aula)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Aulas SET NM_Aula = @Nombre, Cantidad = @Cantidad WHERE Id_Aula = @IdAula";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", aula.NombreAula);
                conexion.agregarParametro("@IdAula", aula.IdAula);
                conexion.agregarParametro("@Cantidad", aula.Cantidad);

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
                conexion.setearConsulta("SELECT MAX(Id_Aula) FROM Aulas");
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
                conexion.setearConsulta("SELECT MIN(Id_Aula) FROM Aulas");
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

        public Aula IrA(int tipo, int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            Aula aux = new Aula();
            string consulta = "";

            try
            {
                switch (tipo)
                {
                    case 0:
                        consulta = "SELECT TOP(1) Id_Aula, NM_Aula, Cantidad FROM Aulas ORDER BY 1 ASC";
                        break;
                    case 1:
                        consulta = "SELECT TOP(1) Id_Aula, NM_Aula, Cantidad FROM Aulas WHERE Id_Aula <" + id.ToString() + "ORDER BY 1 DESC";
                        break;
                    case 2:
                        consulta = "SELECT TOP(1) Id_Aula, NM_Aula, Cantidad FROM Aulas WHERE Id_Aula >" + id.ToString() + "ORDER BY 1 ASC";
                        break;
                    case 3:
                        consulta = "SELECT TOP(1) Id_Aula, NM_Aula, Cantidad FROM Aulas ORDER BY 1 DESC";
                        break;
                }

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdAula = conexion.Lector.GetInt32(0);
                    aux.NombreAula = conexion.Lector.GetString(1);
                    aux.Cantidad = conexion.Lector.GetInt32(2);
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

    }
}

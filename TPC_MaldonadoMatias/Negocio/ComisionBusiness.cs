using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ComisionBusiness
    {
        public IList<Comision> listar(int tipo, string buscar)
        {

            IList<Comision> lista = new List<Comision>();
            AccesoDatos conexion = new AccesoDatos();

            String where = "";
            switch (tipo)
            {
                case 0:
                    where = "NM_Comision like '%" + buscar + "%'";
                    break;
                case 1:
                    where = "Id_Comision = '" + buscar + "'";
                    break;
            }

            string consulta = "SELECT Id_Comision, NM_Comision FROM Comisiones WHERE " + where + " ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
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

        public IList<Comision> listar()
        {

            IList<Comision> lista = new List<Comision>();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT Id_Comision, NM_Comision FROM Comisiones ORDER BY 1";
            try
            {
                conexion.setearConsulta(consulta);
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

        public void agregar(Comision comision)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO Comisiones VALUES (@Nombre)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", comision.NombreComision);

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

        public void modificar(Comision comision)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Comisiones SET NM_Comision = @Nombre WHERE Id_Comision = @IdCurso";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", comision.NombreComision);
                conexion.agregarParametro("@IdCurso", comision.IdComision);

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
                conexion.setearConsulta("SELECT MAX(Id_Comision) FROM Comisiones");
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
                conexion.setearConsulta("SELECT MIN(Id_Comision) FROM Comisiones");
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

        public Comision IrA(int tipo, int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            Comision aux = new Comision();
            string consulta = "";

            try
            {
                switch (tipo)
                {
                    case 0:
                        consulta = "SELECT TOP(1) Id_Comision, NM_Comision  FROM Comisiones ORDER BY 1 ASC";
                        break;
                    case 1:
                        consulta = "SELECT TOP(1) Id_Comision, NM_Comision  FROM Comisiones WHERE Id_Comision <" + id.ToString() + "ORDER BY 1 DESC";
                        break;
                    case 2:
                        consulta = "SELECT TOP(1) Id_Comision, NM_Comision  FROM Comisiones WHERE Id_Comision >" + id.ToString() + "ORDER BY 1 ASC";
                        break;
                    case 3:
                        consulta = "SELECT TOP(1) Id_Comision, NM_Comision  FROM Comisiones ORDER BY 1 DESC";
                        break;
                }

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdComision = conexion.Lector.GetInt32(0);
                    aux.NombreComision = conexion.Lector.GetString(1);
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

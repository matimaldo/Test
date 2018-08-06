using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AbonoBusiness
    {
        public string ObtenerPrecioDia()
        {
            string aux = "";
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Obtener_PrecioDia";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux = conexion.Lector.GetDecimal(0).ToString("N2");
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

        public Abono ObtenerAbono(int cantidad)
        {
            Abono aux = new Abono();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Obtener_Abono";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Cantidad", cantidad);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdAbono = conexion.Lector.GetInt32(0);
                    aux.CantIngresos = conexion.Lector.GetInt32(1);
                    aux.Valor = float.Parse(conexion.Lector.GetDecimal(2).ToString()); //ver
                    aux.Vigente = conexion.Lector.GetBoolean(3);
                    aux.FechaAlta = conexion.Lector.GetDateTime(4);
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

        public void PagarDia(Persona persona, Abono abono)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO AbonosVendidos VALUES (@FechaVenta,@ID_Abono, @ID_Persona,@ID_MediodePago, @NroComprobante)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@FechaVenta", DateTime.Today);
                conexion.agregarParametro("@ID_Abono", abono.IdAbono);
                conexion.agregarParametro("@ID_Persona", persona.IdPersona);
                conexion.agregarParametro("@ID_MediodePago", 1);
                conexion.agregarParametro("@NroComprobante", 0);


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

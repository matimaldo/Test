using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PersonaBusiness
    {
        public Persona Obtener(int DNI)
        {

            Persona aux = new Persona();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SELECT ID_Persona,Nombre,Apellido,DNI,Mail,Huella1,Huella2,Huella3,ID_TipoPersona FROM Personas WHERE DNI = @dni ";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@dni", DNI);

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdPersona = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Apellido = conexion.Lector.GetString(2);
                    aux.Dni = conexion.Lector.GetInt32(3);
                    aux.Mail = conexion.Lector.GetString(4);
                    aux.Huella1 = conexion.Lector.GetString(5);
                    aux.Huella2 = conexion.Lector.GetString(6);
                    aux.Huella3 = conexion.Lector.GetString(7);
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

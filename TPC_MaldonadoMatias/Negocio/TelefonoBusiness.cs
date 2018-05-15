using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class TelefonoBusiness
    {
        public void agregar(Telefono altaTelefono , int idPersona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "insert into Telefonos values (@Id_Persona , @Id_TipoTel, @Numero, @Contacto)";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_Persona", idPersona);
                conexion.agregarParametro("@Id_TipoTel", altaTelefono.TipoTelefono.IdTipoTelefono);
                conexion.agregarParametro("@Numero", altaTelefono.Numero);
                conexion.agregarParametro("@Contacto", altaTelefono.Contacto);

                //consulta += idPersona + ",";
                //consulta += altaTelefono.TipoTelefono.IdTipoTelefono + ",";
                //consulta += "'" + altaTelefono.Numero + "',";
                //consulta += "'" + altaTelefono.Contacto + "')";

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
                conexion = null;
            }
        }

        public void modificar(Telefono telefono, int idPersona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Telefonos SET Id_TipoTel=@Id_TipoTel, Numero=@Numero, Contacto=@Contacto WHERE Id_Persona=@Id_Persona";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Id_TipoTel", telefono.TipoTelefono.IdTipoTelefono);
                conexion.agregarParametro("@Numero", telefono.Numero);
                conexion.agregarParametro("@Contacto", telefono.Contacto);
                conexion.agregarParametro("@Id_Persona", idPersona);


                //consulta += idPersona + ",";
                //consulta += altaTelefono.TipoTelefono.IdTipoTelefono + ",";
                //consulta += "'" + altaTelefono.Numero + "',";
                //consulta += "'" + altaTelefono.Contacto + "')";

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
                conexion = null;
            }
        }

    }
}

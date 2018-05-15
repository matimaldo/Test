using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class TipoTelefonoBusiness
    {
        public IList<TipoTelefono> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<TipoTelefono> lista = new List<TipoTelefono>();

            try
            {
                conexion.setearConsulta("SELECT Id_TipoTel, NM_Tipo FROM TipoTelefonos  ORDER BY 1");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    TipoTelefono aux = new TipoTelefono(conexion.Lector.GetInt32(0),
                                            conexion.Lector.GetString(1));
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
                conexion = null;
            }


        }
    }
}

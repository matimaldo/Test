using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MailBusiness
    {

        public IList<string> listar()
        {
            IList<string> lista = new List<string>();
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SP_Listar_Mail_Todos";

            try
            {
                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    string aux = conexion.Lector.GetString(0);

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
    }
}

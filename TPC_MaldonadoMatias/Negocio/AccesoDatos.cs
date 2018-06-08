using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace Negocio
{
    public class AccesoDatos
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private SqlDataAdapter da;
        private DataTable dt;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection(@"data source=.; initial catalog=MALDONADO_DB; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setearSP(string sp)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

        public void leerConsulta()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void accionEjecutar()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
        public void borrarParametros()
        {
            try
            {
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregarParametro(string nombre, object valor)
        {
            try
            {
                comando.Parameters.AddWithValue(nombre, valor);               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable agragarDataGridView(string consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = consulta;

                da = new SqlDataAdapter(comando);
                dt = new DataTable();
                conexion.Open();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
            conexion = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EmpleadoBusiness
    {
        public IList<Empleado> listar()
        {
            IList<Empleado> lista = new List<Empleado>();
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT P.Id_Persona, P.Nombre, P.Apellido, P.DNI, P.FechaNac, P.Mail, T.Numero, TT.NM_Tipo,RP.Id_Rol FROM dbo.PERSONAS AS P LEFT OUTER JOIN dbo.Telefonos AS T ON P.Id_Persona = T.Id_Persona LEFT OUTER JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL";

            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Empleado aux = new Empleado();

                    aux.IdPersona = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Apellido = conexion.Lector.GetString(2);
                    aux.Dni = conexion.Lector.GetString(3);
                    aux.FechaNac = conexion.Lector.GetDateTime(4);
                    aux.Mail = conexion.Lector.GetString(5);

                    aux.Telefono = new Telefono();
                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Numero")))
                    {
                        aux.Telefono.Numero = conexion.Lector.GetString(6);
                        aux.Telefono.TipoTelefono = new TipoTelefono();
                        aux.Telefono.TipoTelefono.NombreTipoTelefono = conexion.Lector.GetString(7);
                    }
                    else
                        aux.Telefono.Numero = "";

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

        public IList<Empleado> listar(int tipo, string buscar)
        {

            IList<Empleado> lista = new List<Empleado>();
            AccesoDatos conexion = new AccesoDatos();

            String where = "";
            switch (tipo)
            {
                case 0:
                    where = "( P.Nombre like '%" + buscar + "%' or P.Apellido like '%" + buscar + "%' )";
                    break;
                case 1:
                    where = "P.Dni like '%" + buscar + "%'";
                    break;
            }

            string consulta = "SELECT  P.Id_Persona, P.Nombre, P.Apellido, P.Dni, P.FechaNac, P.Sexo, P.Mail, P.Estado, T.Id_Telefono, T.Numero, T.Contacto, T.Id_TipoTel, TT.NM_Tipo FROM Personas AS P LEFT JOIN Telefonos AS T ON P.Id_Persona = T.Id_Persona LEFT JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL AND " + where;
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Empleado aux = new Empleado();

                    aux.IdPersona = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Apellido = conexion.Lector.GetString(2);
                    aux.Dni = conexion.Lector.GetString(3);
                    aux.FechaNac = conexion.Lector.GetDateTime(4);
                    aux.Sexo = conexion.Lector.GetString(5);
                    aux.Mail = conexion.Lector.GetString(6);
                    aux.Estado = conexion.Lector.GetBoolean(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Numero")))
                    {
                        aux.Telefono.IdTelefono = conexion.Lector.GetInt32(8);
                        aux.Telefono.Numero = conexion.Lector.GetString(9);
                        aux.Telefono.Contacto = conexion.Lector.GetString(10);

                        aux.Telefono.TipoTelefono.IdTipoTelefono = conexion.Lector.GetInt32(11);
                        aux.Telefono.TipoTelefono.NombreTipoTelefono = conexion.Lector.GetString(12);
                    }

                    else
                        aux.Telefono.Numero = "";

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

        public void agregar(Empleado persona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO Personas VALUES (@Nombre, @Apellido, @Dni, @FechaNac, @Sexo, @Mail, @Estado)";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", persona.Nombre);
                conexion.agregarParametro("@Apellido", persona.Apellido);
                conexion.agregarParametro("@Dni", persona.Dni);
                conexion.agregarParametro("@FechaNac", persona.FechaNac);
                conexion.agregarParametro("@Sexo", persona.Sexo);
                conexion.agregarParametro("@Mail", persona.Mail);
                conexion.agregarParametro("@Estado", Convert.ToInt32(persona.Estado));

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

        public void modificar(Empleado persona)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE Personas SET Nombre = @Nombre , Apellido = @Apellido, Dni = @Dni, FechaNac = @FechaNac, Sexo = @Sexo, Mail = @Mail, Estado = @Estado WHERE Id_Persona = @IdPersona";

            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@Nombre", persona.Nombre);
                conexion.agregarParametro("@Apellido", persona.Apellido);
                conexion.agregarParametro("@Dni", persona.Dni);
                conexion.agregarParametro("@FechaNac", persona.FechaNac);
                conexion.agregarParametro("@Sexo", persona.Sexo);
                conexion.agregarParametro("@Mail", persona.Mail);
                conexion.agregarParametro("@Estado", Convert.ToInt32(persona.Estado));
                conexion.agregarParametro("@IdPersona", persona.IdPersona);

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

        public int obtenerIDPersona(string DNI)
        {
            AccesoDatos conexion = new AccesoDatos();
            int id = new int();

            try
            {
                conexion.setearConsulta("SELECT Id_Persona FROM Personas WHERE DNI =" + DNI);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    id = conexion.Lector.GetInt32(0);
                }
                return id;
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

        public Empleado empleadoIrA(int tipo, int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            Empleado aux = new Empleado();
            string consulta = "";

            try
            {
                switch (tipo)
                {
                    case 0:
                        consulta = "SELECT TOP(1) P.Id_Persona, P.Nombre, P.Apellido, P.Dni, P.FechaNac, P.Sexo, P.Mail, P.Estado, T.Id_Telefono, T.Numero, T.Contacto, T.Id_TipoTel, TT.NM_Tipo FROM Personas AS P LEFT JOIN Telefonos AS T ON P.Id_Persona = T.Id_Persona LEFT JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL ORDER BY 1 ASC";
                        break;
                    case 1:
                        consulta = "SELECT TOP(1) P.Id_Persona, P.Nombre, P.Apellido, P.Dni, P.FechaNac, P.Sexo, P.Mail, P.Estado, T.Id_Telefono, T.Numero, T.Contacto, T.Id_TipoTel, TT.NM_Tipo FROM Personas AS P LEFT JOIN Telefonos AS T ON P.Id_Persona = T.Id_Persona LEFT JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL AND P.Id_Persona <" + id.ToString() + "ORDER BY 1 DESC";
                        break;
                    case 2:
                        consulta = "SELECT TOP(1) P.Id_Persona, P.Nombre, P.Apellido, P.Dni, P.FechaNac, P.Sexo, P.Mail, P.Estado, T.Id_Telefono, T.Numero, T.Contacto, T.Id_TipoTel, TT.NM_Tipo FROM Personas AS P LEFT JOIN Telefonos AS T ON P.Id_Persona = T.Id_Persona LEFT JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL AND P.Id_Persona >" + id.ToString() + "ORDER BY 1 ASC";
                        break;
                    case 3:
                        consulta = "SELECT TOP(1) P.Id_Persona, P.Nombre, P.Apellido, P.Dni, P.FechaNac, P.Sexo, P.Mail, P.Estado, T.Id_Telefono, T.Numero, T.Contacto, T.Id_TipoTel, TT.NM_Tipo FROM Personas AS P LEFT JOIN Telefonos AS T ON P.Id_Persona = T.Id_Persona LEFT JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL ORDER BY 1 DESC";
                        break;
                }

                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdPersona = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Apellido = conexion.Lector.GetString(2);
                    aux.Dni = conexion.Lector.GetString(3);
                    aux.FechaNac = conexion.Lector.GetDateTime(4);
                    aux.Sexo = conexion.Lector.GetString(5);
                    aux.Mail = conexion.Lector.GetString(6);
                    aux.Estado = conexion.Lector.GetBoolean(7);

                    if (!conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("Numero")))
                    {
                        aux.Telefono.IdTelefono = conexion.Lector.GetInt32(8);
                        aux.Telefono.Numero = conexion.Lector.GetString(9);
                        aux.Telefono.Contacto = conexion.Lector.GetString(10);

                        aux.Telefono.TipoTelefono.IdTipoTelefono = conexion.Lector.GetInt32(11);
                        aux.Telefono.TipoTelefono.NombreTipoTelefono = conexion.Lector.GetString(12);
                    }

                    else
                        aux.Telefono.Numero = "";
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
                conexion.setearConsulta("SELECT ISNULL(MAX(P.Id_Persona),0) FROM Personas P LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL ");
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
                conexion.setearConsulta("SELECT ISNULL(MIN(P.Id_Persona),0) FROM Personas P LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona WHERE Id_Rol IS NOT NULL ");
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
    }
}

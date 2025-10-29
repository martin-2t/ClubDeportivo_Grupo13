using ClubDeportivoNET80.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Datos
{
    internal class Clientes
    {

        public static string? RegistrarSocio(E_Socio socio, string modoPago, string promocion)
        {
            // Inicialización de la variable de salida
            string? salida = null;

            MySqlConnection? sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("tipo_documento", MySqlDbType.Int32).Value = socio.TipoDocumento;
                comando.Parameters.Add("numero_documento", MySqlDbType.VarChar).Value = socio.NumeroDocumento;
                comando.Parameters.Add("email", MySqlDbType.VarChar).Value = socio.Email;
                comando.Parameters.Add("telefono", MySqlDbType.VarChar).Value = socio.Telefono;
                comando.Parameters.Add("es_socio", MySqlDbType.Bit).Value = socio.EsSocio;
                comando.Parameters.Add("apto_fisico", MySqlDbType.Bit).Value = socio.AptoFisico;

                comando.Parameters.Add("modo_pago", MySqlDbType.VarChar).Value = modoPago;
                comando.Parameters.Add("promocion", MySqlDbType.VarChar).Value = promocion;
                comando.Parameters.Add("monto", MySqlDbType.Decimal).Value = E_CuotaMensual.MontoFijo;

                // definimos los parametros de salida
                MySqlParameter respuesta = new MySqlParameter();
                respuesta.ParameterName = "respuesta";
                respuesta.MySqlDbType = MySqlDbType.Int32;
                respuesta.Direction = ParameterDirection.Output;

                MySqlParameter fecha_alta = new MySqlParameter();
                fecha_alta.ParameterName = "fecha_alta";
                fecha_alta.MySqlDbType = MySqlDbType.Timestamp;
                fecha_alta.Direction = ParameterDirection.Output;


                comando.Parameters.Add(respuesta);
                comando.Parameters.Add(fecha_alta);

                Conexion.AbrirConexion(sqlCon);

                comando.ExecuteNonQuery();

                CargarParametrosSalida(respuesta, fecha_alta, socio);

                salida = Convert.ToString(respuesta.Value);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }

            // Como proceso final, no importa qué pase en el medio.
            finally
            {
                Conexion.CerrarConexion(sqlCon);
            }

            // SALIDA
            return salida;
        }

        // Valida y carga los parametros necesarios para el carnet
        // obtenidos desde la db, en la instancia de socio.
        private static void CargarParametrosSalida(MySqlParameter id, MySqlParameter fecha_alta, E_Socio socio)
        {
            if (id.Value != DBNull.Value && Convert.ToInt32(id.Value) > 0)
            {
                socio.Id = Convert.ToInt32(id.Value);

                if (fecha_alta.Value != DBNull.Value)
                    socio.FechaAlta = Convert.ToDateTime(fecha_alta.Value);
            }

        }

        public static string? RegistrarNoSocio(E_NoSocio noSocio) 
        {
            // Inicialización de la variable de salida
            string? salida = null;

            MySqlConnection? sqlCon = null;

            try
            {

                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevoNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("tipo_documento", MySqlDbType.Int32).Value = noSocio.TipoDocumento;
                comando.Parameters.Add("numero_documento", MySqlDbType.VarChar).Value = noSocio.NumeroDocumento;
                comando.Parameters.Add("email", MySqlDbType.VarChar).Value = noSocio.Email;
                comando.Parameters.Add("telefono", MySqlDbType.VarChar).Value = noSocio.Telefono;
                comando.Parameters.Add("apto_fisico", MySqlDbType.Bit).Value = noSocio.AptoFisico;


                MySqlParameter respuesta = new MySqlParameter();
                respuesta.ParameterName = "respuesta";
                respuesta.MySqlDbType = MySqlDbType.Int32;
                respuesta.Direction = ParameterDirection.Output;

                comando.Parameters.Add(respuesta);

                Conexion.AbrirConexion(sqlCon);

                comando.ExecuteNonQuery();

                salida = Convert.ToString(respuesta.Value);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                Conexion.CerrarConexion(sqlCon);

            }

            //SALIDA
            return salida;

        }

        public static E_Cliente? ObtenerCliente(int id)
        {
            E_Cliente? cliente = null;
            MySqlConnection? sqlCon = null;

            // Para leer las filas de la db
            MySqlDataReader? lector = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ObtenerCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = id;

                Conexion.AbrirConexion(sqlCon);

                lector = comando.ExecuteReader();

                // Si hay información en la db.
                if (lector.Read())
                {
           
                    bool esSocio = Convert.ToBoolean(lector["es_socio"]);

                    if (esSocio)
                    {
                        cliente = new E_Socio(
                            lector.GetInt32("id_cliente"),
                            lector["nombre"]?.ToString() ?? "",
                            lector["apellido"]?.ToString() ?? "",
                            lector["estado"]?.ToString() ?? ""
                         );

                    }
                    else
                    {
                        cliente = new E_NoSocio(
                            lector.GetInt32("id_cliente"),
                            lector["nombre"]?.ToString() ?? "",
                            lector["apellido"]?.ToString() ?? ""
                        );

                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener datos del cliente.", ex);
            }
            finally
            {
                // Cierra el lector
                if (lector != null && !lector.IsClosed)
                    lector.Close();

                Conexion.CerrarConexion(sqlCon);
            }

            return cliente;
        }

        // Recibe el id del cliente y
        // llama al procedimiento almacenado en la db
        // para actualizar el estado del cliente.
        public static void ActualizarEstadoCliente(int id)
        {

            MySqlConnection? sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ActualizarEstadoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = id;

                Conexion.AbrirConexion(sqlCon);

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar actualizar el estado del cliente en la db.", ex);

            }
            finally
            {
                Conexion.CerrarConexion(sqlCon);
            }

        }

        // Devuelve la lista de socios morosos obtenida desde la db
        public static List<E_Socio> ObtenerSociosMorosos()
        {
            List<E_Socio> sociosMorosos = new List<E_Socio>();

            MySqlConnection? sqlCon = null;
            MySqlDataReader? lector = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ObtenerSociosMorosos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                Conexion.AbrirConexion(sqlCon);

                lector = comando.ExecuteReader();

                // Mientras haya filas para leer, recorrerlas.
                while (lector.Read())
                {
                    E_Socio socio = new E_Socio(
                                                lector.GetInt32("id_cliente"),
                                                lector["nombre"]?.ToString() ?? "",
                                                lector["apellido"]?.ToString() ?? ""
                    );

                    // Agrega el socio moroso obtenido a la lista.
                    sociosMorosos.Add(socio);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener los socios morosos de la base de datos.", ex);
            }
            finally
            {
                // Cerrar lector.
                if (lector != null && !lector.IsClosed)
                    lector.Close();

                Conexion.CerrarConexion(sqlCon);
            }

            // SALIDA
            return sociosMorosos;
        }


        // FIN
    }
}

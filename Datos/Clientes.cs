using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Clientes
    {

        public string Nuevo_Socio(E_Socio socio, E_CuotaMensual cuotaMensual)
        {
            string salida = null;

            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = socio.nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = socio.apellido;
                comando.Parameters.Add("tipo_documento", MySqlDbType.Int32).Value = socio.tipo_documento;
                comando.Parameters.Add("numero_documento", MySqlDbType.VarChar).Value = socio.numero_documento;
                comando.Parameters.Add("email", MySqlDbType.VarChar).Value = socio.email;
                comando.Parameters.Add("telefono", MySqlDbType.VarChar).Value = socio.telefono;
                comando.Parameters.Add("es_socio", MySqlDbType.Bit).Value = socio.es_socio;
                comando.Parameters.Add("apto_fisico", MySqlDbType.Bit).Value = socio.apto_fisico;
                comando.Parameters.Add("modo_pago", MySqlDbType.VarChar).Value = cuotaMensual.ModoPago;
                comando.Parameters.Add("promocion", MySqlDbType.VarChar).Value = cuotaMensual.Promocion;
                comando.Parameters.Add("monto", MySqlDbType.Decimal).Value = cuotaMensual.Monto;


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

                // Si la conexion no es nula, la abre, sino sale.
                if (sqlCon != null)
                {
                    sqlCon.Open();
                }
                else
                {
                    throw new InvalidOperationException(
                    "No se pudo crear la conexión con la base de datos. " +
                    "Verifique la configuración de la clase 'Conexion'.");
                }

                comando.ExecuteNonQuery();

                if ( respuesta.Value != DBNull.Value && Convert.ToInt32(respuesta.Value) > 0)
                {
                    socio.id_cliente = Convert.ToInt32(respuesta.Value);

                    if (fecha_alta.Value != DBNull.Value )
                        socio.fecha_alta = Convert.ToDateTime(fecha_alta.Value);
                }

                salida = Convert.ToString(respuesta.Value);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }

            // como proceso final
            finally
            {
                // Si no es nula y está abierta, la cierra.
                if (sqlCon != null && sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }

            }

            return salida;
        }
    }
}

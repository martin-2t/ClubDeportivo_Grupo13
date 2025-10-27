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
    internal class Cuotas
    {

        // Chequea con la db si el cliente en cuestion tiene cuotas por pagar.
        // Devuelve -3 si hay algun error de conexion.
        // 0 si no tiene cuotas por pagar.
        // 1 si tiene cuotas por pagar.
        // -2 por si hubo algun error antes de entrar al try.
        public static int TieneCuotasPendientes(int idCliente)
        {
            // valor default
            int salida = -2;

            bool tiene = false;
            MySqlConnection? sqlCon = null;


            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("TieneCuotasPendientes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = idCliente;

                MySqlParameter respuesta = new MySqlParameter();
                respuesta.ParameterName = "tiene";
                respuesta.MySqlDbType = MySqlDbType.Bit;
                respuesta.Direction = ParameterDirection.Output;

                comando.Parameters.Add(respuesta);

                Conexion.AbrirConexion(sqlCon);

                comando.ExecuteNonQuery();
                tiene = Convert.ToBoolean(respuesta.Value);

                salida = tiene ? 1 : 0;

            }
            catch (Exception)
            {
                salida = -3;

            }
            finally
            {
                Conexion.CerrarConexion(sqlCon);
            }

            return salida;

        }

        
        // Obtiene las cuotas pendientes y vencidas del cliente
        // junta a la última que pago. 
        public static List<E_CuotaMensual> ObtenerCuotas(int idCliente)
        {

            MySqlConnection? sqlCon = null;
            MySqlDataReader? lector = null;

            List<E_CuotaMensual> cuotas = new List<E_CuotaMensual>();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ObtenerCuotas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = idCliente;

                Conexion.AbrirConexion(sqlCon);

                lector = comando.ExecuteReader();

                // Mientras haya filas para leer
                while (lector.Read())
                {
                    E_CuotaMensual cuota = new E_CuotaMensual(
                                            lector.GetInt32("id_cuota"),
                                            lector.GetDecimal("monto"),
                                            lector.GetDateTime("fecha_vencimiento"),
                                            lector["fecha_pago"] == DBNull.Value ? null : lector.GetDateTime("fecha_pago"),
                                            lector["estado"]?.ToString() ?? ""

                    );

                    // Agrega la cuota creada a la lista de cuotas
                    cuotas.Add(cuota);

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar recuperar cuotas del cliente", ex);

            }
            finally
            {
                // Cerrar lector
                if (lector != null && !lector.IsClosed) lector.Close();

                Conexion.CerrarConexion(sqlCon);
            }

            return cuotas;
        }

        // Registra el pago de las cuotas mensuales pagadas por el socio.
        public static void PagarCuotasMensuales(
            List<E_CuotaMensual> cuotas, 
            string modoPago, 
            string promocion)
        {
            int salida;

            MySqlConnection? sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("PagarCuotaMensual", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                MySqlParameter idParametro = comando.Parameters.Add("id_cuota", MySqlDbType.Int32);
                comando.Parameters.Add("modo_pago", MySqlDbType.VarChar).Value = modoPago;
                comando.Parameters.Add("promocion", MySqlDbType.VarChar).Value = promocion;

                MySqlParameter respuesta = new MySqlParameter();
                respuesta.ParameterName = "resultado";
                respuesta.MySqlDbType = MySqlDbType.Int32;
                respuesta.Direction = ParameterDirection.Output;

                comando.Parameters.Add(respuesta);

                Conexion.AbrirConexion(sqlCon);

                // Rcorre cada cuota y llama al procedimiento almacenado para pagarla.
                foreach (E_CuotaMensual cuota in cuotas)
                {
                    idParametro.Value = cuota.Id;
                    comando.ExecuteNonQuery();
                    salida = Convert.ToInt32(respuesta.Value);

                    // Si por algun motivo el pago falla,
                    // aviso qué cuota no pudo pagarse.

                    if (salida != 1)
                    {
                        throw new Exception($"No se pudo pagar la cuota con ID {cuota.Id}");
                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos.", ex);

            }
            finally
            {

                Conexion.CerrarConexion(sqlCon);
            }

        }


        // Registra el pago de las actividades pagadas en el dia por el no socio.
        public static void PagarCuotaDiaria(
            List<int> idActividades, 
            string modoPago, 
            string? promocion, 
            int idCliente)
        {
            MySqlConnection? sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("PagarCuotaDiaria", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                MySqlParameter actividadParametro = comando.Parameters.Add("id_actividad", MySqlDbType.Int32);
                comando.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = idCliente;
                comando.Parameters.Add("modo_pago", MySqlDbType.VarChar).Value = modoPago;
                comando.Parameters.Add("promocion", MySqlDbType.VarChar).Value = promocion;

                Conexion.AbrirConexion(sqlCon);

                // Llama al procedimiento por cada actividad
                // Para registrar cuota diaria por cada una.
                foreach (int id in idActividades)
                {
                    actividadParametro.Value = id;
                    comando.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar registrar cuota diara.", ex);

            }
            finally
            {
                Conexion.CerrarConexion(sqlCon);

            }

        }


        // FIN
    }
}

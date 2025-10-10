using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Datos
{
    internal class Usuarios
    {

        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string usuario, string clave)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection? sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("usuario", MySqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("clave", MySqlDbType.VarChar).Value = clave;

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

                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos.", ex);
            }

            // como proceso final
            finally
            {
                // Si no es nula y está abierta, la cierra.
                if (sqlCon != null && sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }

            }
        }



    }
}

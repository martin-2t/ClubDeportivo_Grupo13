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
    internal class Actividades
    {

        // Obtiene las actividades desde la bd usando
        // el procedimiento almacenado ObtenerActividades
        // Devuelve la lista con dichas actividades.
        public static List<E_Actividad> ObtenerActividades()
        {

            MySqlConnection? sqlCon = null;
            MySqlDataReader? lector = null;
            List<E_Actividad> actividades = new List<E_Actividad>();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ObtenerActividades", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                Conexion.AbrirConexion(sqlCon);

                lector = comando.ExecuteReader();

                // Mientras haya filas para leer, recorrerlas.
                while (lector.Read())
                {
                    E_Actividad actividad = new E_Actividad(
                                            lector.GetInt32("id_actividad"),
                                            lector.GetDecimal("monto"),
                                            lector["nombre"]?.ToString() ?? ""

                    );

                    // Agrega la actividad obtenida a la lista de actividades.
                    actividades.Add(actividad);

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos.", ex);

            }
            finally
            {
                // Cerrar lector
                if (lector != null && !lector.IsClosed) lector.Close();

                Conexion.CerrarConexion(sqlCon);
            }

            return actividades;
        }

        // FIN
    }
}

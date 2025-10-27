using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Datos
{
    internal class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;



        private Conexion()
        {
            // tiene que estar en la misma carpeta que el .exe.
            // ir a propiedades y elegir copy if newer en copy to output directory o ponerlo manualmente.
            string direccionJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mysql.config.json");

            if (File.Exists(direccionJson)) // nombre del archivo json con tus datos. 
            {
                var jsonBdDatos = File.ReadAllText(direccionJson); // lee el archivo.
                var conexDatos = JsonDocument.Parse(jsonBdDatos).RootElement.GetProperty("DatosConexion");

                this.baseDatos = conexDatos.GetProperty("NombreBd").GetString() ?? "Proyecto";
                this.servidor = conexDatos.GetProperty("Servidor").GetString() ?? "localhost";
                this.puerto = conexDatos.GetProperty("Puerto").GetString() ?? "3306";
                this.usuario = conexDatos.GetProperty("Usuario").GetString() ?? "root";
                this.clave = conexDatos.GetProperty("Clave").GetString() ?? "";

            }
            else
            {
                // Si no, ponen la config que necesiten acá.
                this.baseDatos = "Proyecto";
                this.servidor = "localhost";
                this.puerto = "3306";
                this.usuario = "root";
                this.clave = "";
            }
        }

        public MySqlConnection CrearConcexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception(
                    "Error al construir la cadena de conexión MySQL. " +
                    "Verifica servidor, puerto, usuario, contraseña y nombre de base de datos.",
                    ex);
            }
            return cadena;
        }


        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }

        // Si la conexion no es nula, la abre, sino sale.
        public static void AbrirConexion(MySqlConnection? sqlCon)
        {
            if (sqlCon != null)
            {
                sqlCon.Open();
            }
            else
            {
                throw new InvalidOperationException(
                        "La conexión no fue creada" +
                        "Verifique la configuración de la clase 'Conexion'.");
            }

        }

        // Si no es nula y está abierta, la cierra.
        public static void CerrarConexion(MySqlConnection? sqlCon)
        {

            if (sqlCon != null && sqlCon.State == ConnectionState.Open) 
            { 
                sqlCon.Close(); 
            }

        }


    // FIN
    }
}

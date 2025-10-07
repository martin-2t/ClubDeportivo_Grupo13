using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Conexion
    {

        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        

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
            MySqlConnection cadena = new MySqlConnection();

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
                throw;
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
    }
}



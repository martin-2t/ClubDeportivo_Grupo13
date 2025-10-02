using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class conexión
    {
        
        private string cadena = "server=localhost;port=3306;database=bd_club;uid=root;pwd=Rojo123;";

        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(cadena);
        }
    }
}

